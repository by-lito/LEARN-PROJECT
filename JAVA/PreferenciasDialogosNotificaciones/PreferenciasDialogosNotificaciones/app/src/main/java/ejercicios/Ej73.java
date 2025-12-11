package ejercicios;

import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import com.example.preferenciasdialogosnotificaciones.R;

import java.util.ArrayList;

public class Ej73 extends AppCompatActivity implements View.OnClickListener {

    Button btnList, btnBtns;

    final String[] elementos = {"METROID", "BAYONETTA", "ZELDA", "ANGEL"};

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_actividad3);

        btnBtns = findViewById(R.id.btnBotones);
        btnList = findViewById(R.id.btnListado);

        btnBtns.setOnClickListener(this);
        btnList.setOnClickListener(this);


    }

    @Override
    public void onClick(View v) {

        if (v.getId() == R.id.btnBotones) {
            mostrarDialogoConBotones();
        } else if (v.getId() == R.id.btnListado) {
            mostrarDialogoListado();
        }

    }

    private void mostrarToast(String mensaje) {
        Toast.makeText(this, mensaje, Toast.LENGTH_SHORT).show();
    }

    private void mostrarDialogoConBotones() {
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("CONSOLAS")
                .setMessage("TE GUSTAN LOS VIDEOJUEGOS?")
                // Botón Positivo
                .setPositiveButton("SI", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                        mostrarToast("HA ELEGIDO SI");
                    }
                })
                // Botón Negativo
                .setNegativeButton("SI", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                        mostrarToast("HA ELEGIDO CASI");
                    }
                })
                // Botón Neutral
                .setNeutralButton("SI", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                        mostrarToast("HA QUERIDO ELEGIR NO PERO SI");
                    }
                });

        builder.create().show();
    }


    private void mostrarDialogoListado() {
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("DIÁLOGO DE LISTADO")
                // Usamos setItems con el array y un listener
                .setItems(elementos, new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                        // 'id' es la posición del elemento pulsado (0, 1, 2...)
                        mostrarToast("Has elegido: " + elementos[id]);
                    }
                });

        builder.create().show();
    }
}
