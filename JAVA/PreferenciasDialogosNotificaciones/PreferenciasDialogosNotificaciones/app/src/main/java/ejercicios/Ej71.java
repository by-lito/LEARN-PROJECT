package ejercicios;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.preference.PreferenceManager;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.preferenciasdialogosnotificaciones.OpcionesPreferencias;
import com.example.preferenciasdialogosnotificaciones.OpcionesPreferenciasAct1;
import com.example.preferenciasdialogosnotificaciones.R;

import java.util.prefs.Preferences;

public class Ej71 extends AppCompatActivity implements View.OnClickListener {

    Button btnAbrir;
    Button btnLogs;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_actividad1);

        btnAbrir = findViewById(R.id.btnAbrirPreferencias);
        btnLogs = findViewById(R.id.btnMostrarPreferencias);

        btnAbrir.setOnClickListener(this);
        btnLogs.setOnClickListener(this);

    }

    @Override
    public void onClick(View v) {

        int id = v.getId();

        if (id == R.id.btnAbrirPreferencias){
            startActivity(new Intent(Ej71.this, OpcionesPreferenciasAct1.class));
        } else if (id == R.id.btnMostrarPreferencias) {

            SharedPreferences preferences = PreferenceManager.getDefaultSharedPreferences(this);

            Log.d("ANGEL PREFERENCIA","UNICO OS:  " + preferences.getBoolean("clave1",false));
            Log.d("ANGEL PREFERENCIA","VERSION DEL SISTEMA:  " + preferences.getString("clave2","sin valor"));
            Log.d("ANGEL PREFERENCIA","SISTEMA OPERATIVO:  " + preferences.getString("clave3","no seleccionado"));

        }

    }
}
