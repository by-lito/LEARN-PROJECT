package com.example.listadosymenus.ejercicios;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.listadosymenus.R;

public class Ej64 extends AppCompatActivity {

    Spinner sp;
    TextView tv;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad4_layout);

        sp = findViewById(R.id.spinnerPaises);
        tv = findViewById(R.id.textViewPaisSeleccionado);

        String[] videogames = {"METROID", "ZELDA", "BAYONETTA", "SILKSONG",
                "BLOODBORN", "BLASPHEMOUS", "SMASH", "ARKHAM", "LEAGUE", "ANGEL"};

        ArrayAdapter<String> adp = new ArrayAdapter<>(
                this, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item, videogames
        );

        sp.setAdapter(adp);

        sp.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                tv.setText(parent.getItemAtPosition(position).toString());
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {
                tv.setText("ANGEL");
            }
        });

    }
}
