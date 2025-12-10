package com.example.listadosymenus.ejercicios;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.GridView;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.listadosymenus.R;

public class Ej63 extends AppCompatActivity {

    GridView gv;
    TextView tv;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad3_layout);

        gv = findViewById(R.id.gridViewPaises);
        tv = findViewById(R.id.textViewPaisSeleccionado);

        String[] videogames = {"METROID", "ZELDA", "BAYONETTA", "HOLLOW KNIGHT",
                "DARK SOULS", "BLASPHEMOUS", "SMASH BROS", "BATMAN ARKHAM", "LEAGUE", "ANGEL"};

        ArrayAdapter<String> adp = new ArrayAdapter<>(
                this, R.layout.list_item_videogames, R.id.textViewItemVideogame, videogames);

        gv.setAdapter(adp);

        gv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                String elemento = (String) parent.getItemAtPosition(position);
                tv.setText(elemento);
            }
        });
    }
}