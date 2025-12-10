package com.example.listadosymenus.ejercicios;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.widget.TextView;
import androidx.appcompat.widget.Toolbar;


import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.listadosymenus.R;


public class Ej69 extends AppCompatActivity {

    TextView tv;
    Toolbar tb;


    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad9_layout);

        tv = findViewById(R.id.textViewResultado);
        tb = findViewById(R.id.my_toolbar);

        setSupportActionBar(tb);

    }

    public boolean onCreateOptionsMenu(Menu menu) {

        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.main_menu, menu);

        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {

        int id = item.getItemId();
        if (id == R.id.opcion_a) {
            tv.setText("ZELDA");
        } else if (id == R.id.opcion_b) {
            tv.setText("METROID");
        } else if (id == R.id.opcion_c) {
            tv.setText("ANGEL");
        } else {
            return super.onOptionsItemSelected(item);
        }
        return true;

    }
}
