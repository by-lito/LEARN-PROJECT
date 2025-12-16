package ejercicios;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.Toast;

import com.example.materialdesign.R;
import com.google.android.material.button.MaterialButton;
import com.google.android.material.textfield.TextInputEditText;
import com.google.android.material.textfield.TextInputLayout;
import java.util.regex.Pattern;

public class Ej83 extends AppCompatActivity {

    private TextInputLayout textInputLayoutNombre, textInputLayoutCorreo,textInputLayoutJuego, textInputLayoutTelefono;
    private TextInputEditText editTextNombre, editTextCorreo, editTextTelefono;
    private MaterialButton buttonCancelar, buttonAceptar;
    private Spinner spinnerJuego;

    // Expresiones regulares para validación
    private static final Pattern PATTERN_NOMBRE = Pattern.compile("^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\\s]{3,30}$");
    private static final Pattern PATTERN_CORREO = Pattern.compile("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,6}$");
    private static final Pattern PATTERN_TELEFONO = Pattern.compile("^[+]?[0-9]{9,15}$");

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_activity3);

        // Inicialización de vistas
        textInputLayoutNombre = findViewById(R.id.textInputLayoutNombre);
        editTextNombre = findViewById(R.id.editTextNombre);
        textInputLayoutCorreo = findViewById(R.id.textInputLayoutCorreo);
        editTextCorreo = findViewById(R.id.editTextCorreo);
        textInputLayoutTelefono = findViewById(R.id.textInputLayoutTelefono);
        editTextTelefono = findViewById(R.id.editTextTelefono);
        buttonCancelar = findViewById(R.id.buttonCancelar);
        buttonAceptar = findViewById(R.id.buttonAceptar);
        spinnerJuego = findViewById(R.id.spinnerJuego);
        textInputLayoutJuego = findViewById(R.id.textInputLayoutJuego);

        String[] juegos = new String[]{"Seleccione un Juego", "Minecraft", "Stardew Valley", "The Witcher 3", "Fortnite", "League of Legends"};
        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_spinner_dropdown_item, juegos);

        spinnerJuego.setAdapter(adapter);

        // Asignar los listeners
        setupTextWatchers();
        setupButtonListeners();
    }

    private void setupTextWatchers() {
        editTextNombre.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {}
            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                textInputLayoutNombre.setError(null);
            }
            @Override
            public void afterTextChanged(Editable s) {
                validarNombre();
            }
        });

        editTextCorreo.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {}
            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                textInputLayoutCorreo.setError(null);
            }
            @Override
            public void afterTextChanged(Editable s) {
                validarCorreo();
            }
        });

        editTextTelefono.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {}
            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                textInputLayoutTelefono.setError(null);
            }
            @Override
            public void afterTextChanged(Editable s) {
                validarTelefono();
            }
        });
    }

    private void setupButtonListeners() {
        buttonCancelar.setOnClickListener(v -> {
            Toast.makeText(Ej83.this, "Operación cancelada", Toast.LENGTH_SHORT).show();
            // Limpiar los campos
            editTextNombre.setText("");
            editTextCorreo.setText("");
            editTextTelefono.setText("");
        });

        buttonAceptar.setOnClickListener(v -> {
            if (validarTodosLosCampos()) {
                String selectedGame = spinnerJuego.getSelectedItem().toString();
                Toast.makeText(Ej83.this, "Registro correcto! Juego favorito: " + selectedGame, Toast.LENGTH_LONG).show();
                } else {
                Toast.makeText(Ej83.this, "Corrige los errores", Toast.LENGTH_SHORT).show();
            }
        });
    }

    // Métodos de validación (nombre, correo, teléfono)
    private boolean validarNombre() {
        String nombre = editTextNombre.getText().toString().trim();
        if (nombre.isEmpty() || !PATTERN_NOMBRE.matcher(nombre).matches()) {
            textInputLayoutNombre.setError("Nombre inválido (3-30 caracteres, solo letras)");
            return false;
        }
        textInputLayoutNombre.setError(null);
        return true;
    }

    private boolean validarCorreo() {
        String correo = editTextCorreo.getText().toString().trim();
        if (correo.isEmpty() || !PATTERN_CORREO.matcher(correo).matches()) {
            textInputLayoutCorreo.setError("Correo inválido");
            return false;
        }
        textInputLayoutCorreo.setError(null);
        return true;
    }

    private boolean validarTelefono() {
        String telefono = editTextTelefono.getText().toString().trim();
        if (telefono.isEmpty() || !PATTERN_TELEFONO.matcher(telefono).matches()) {
            textInputLayoutTelefono.setError("Teléfono inválido (9-15 dígitos)");
            return false;
        }
        textInputLayoutTelefono.setError(null);
        return true;
    }

    private boolean validarTodosLosCampos() {

        boolean esNombreValido = validarNombre();
        boolean esCorreoValido = validarCorreo();
        boolean esTelefonoValido = validarTelefono();

        if (spinnerJuego.getSelectedItemPosition() == 0) {  // Ensure a valid game is selected
            textInputLayoutJuego.setError("Por favor, selecciona un juego");
            return false;
        } else {
            textInputLayoutJuego.setError(null);
        }

        return validarNombre() && validarCorreo() && validarTelefono();
    }
}

