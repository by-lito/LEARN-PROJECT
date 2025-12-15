package ejercicios;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Toast;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.materialdesign.R;
import com.google.android.material.appbar.MaterialToolbar;
import com.google.android.material.button.MaterialButton;

public class Ej81 extends AppCompatActivity {
    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_activity1);

        MaterialToolbar toolbar = findViewById(R.id.mainToolbar);

        // ¡MUY IMPORTANTE! Esto le dice a Android que use nuestra ToolBar
        // como si fuera la ActionBar principal.
        setSupportActionBar(toolbar);

        // 3. Configurar el botón "AÑADIR" (de la parte inferior)
        MaterialButton botonAnadir = findViewById(R.id.botonAnadir);
        botonAnadir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Acción simple para el botón
                Toast.makeText(Ej81.this, "Clic en AÑADIR",
                        Toast.LENGTH_SHORT).show();
            }
        });
    }

    /**
     * Este método se llama para "inflar" (crear) el menú de la ToolBar.
     * Le decimos qué archivo XML de menú debe usar.
     */
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu1, menu);
        return true; // Devuelve true para mostrar el menú
    }

    /**
     * Este método se llama cada vez que el usuario presiona
     * un ítem del menú de la ToolBar.
     */
    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Obtenemos el ID del ítem presionado
        int id = item.getItemId();

        // Comparamos el ID con los IDs que definimos en main_toolbar_menu.xml

        if (id == R.id.action_add) {
            // Acción para "Añadir"
            Toast.makeText(this, "Clic en Añadir", Toast.LENGTH_SHORT).show();
            return true; // Indicamos que hemos manejado el clic

        } else if (id == R.id.action_edit) {
            // Acción para "Editar"
            Toast.makeText(this, "Clic en Editar", Toast.LENGTH_SHORT).show();
            return true;

        } else if (id == R.id.action_more) {
            // Acción para "Más"
            Toast.makeText(this, "Clic en Más", Toast.LENGTH_SHORT).show();
            return true;
        }

        // Si no reconocemos el ítem, dejamos que Android lo maneje
        return super.onOptionsItemSelected(item);
    }
}

