package com.example.listadosymenus.ejercicios;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.listadosymenus.R;
import com.example.listadosymenus.adapters.VideogameAdapter;
import com.example.listadosymenus.pojos.Videogame;

import java.util.ArrayList;

public class Ej65 extends AppCompatActivity {

    TextView tvTitle;
    TextView tvDescription;
    ImageView img;
    ListView lv;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad5_layout);

        lv = findViewById(R.id.listViewComplejo);
        tvTitle = findViewById(R.id.textViewNombre);
        tvDescription = findViewById(R.id.textViewDescripcion);
        img = findViewById(R.id.imageViewVideogame);

        ArrayList<Videogame> videogames = new ArrayList<>();

        videogames.add(new Videogame("ZELDA"
                ,R.drawable.zelda
                ,"https://zelda.nintendo.com/"
                ,"Jueguito de aventuras"));
        videogames.add(new Videogame("METROID"
                ,R.drawable.metroid
                ,"https://metroid.nintendo.com/"
                ,"Jueguito de exploración"));
        videogames.add(new Videogame("HOLLOW KNIGHT",
                R.drawable.hollow_knight,
                "https://www.hollowknight.com/",
                "Metroidvania desafiante y atmosférico"));

        videogames.add(new Videogame("DARK SOULS",
                R.drawable.darksouls,
                "https://en.bandainamcoent.eu/dark-souls/dark-souls-remastered",
                "Acción difícil y oscura"));

        videogames.add(new Videogame("ELDEN RING",
                R.drawable.eldenring,
                "https://en.bandainamcoent.eu/elden-ring/elden-ring",
                "Aventura gigantesca en mundo abierto"));

        videogames.add(new Videogame("SUPER SMASH BROS ULTIMATE",
                R.drawable.smash,
                "https://www.smashbros.com/en_US/",
                "Peleas épicas con personajes de Nintendo"));

        videogames.add(new Videogame("BAYONETTA",
                R.drawable.bayonetta,
                "https://www.platinumgames.com/games/bayonetta",
                "Hack and slash frenético"));

        videogames.add(new Videogame("PERSONA 5",
                R.drawable.p5,
                "https://persona.atlus.com/p5r/",
                "JRPG estiloso con un gran grupo de personajes"));

        videogames.add(new Videogame("GOD OF WAR",
                R.drawable.godofwar,
                "https://www.playstation.com/en-us/god-of-war/",
                "Acción cinematográfica con Kratos"));
        videogames.add(new Videogame("ANGEL"
                ,R.drawable.urano
                ,""
                ,"YO!"));

        VideogameAdapter adapter = new VideogameAdapter(this,videogames);

        lv.setAdapter(adapter);

        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Videogame vg = videogames.get(position);

                if (!vg.getUrl().isEmpty()){

                    startActivity(new Intent(Intent.ACTION_VIEW, Uri.parse(vg.getUrl())));
                }
            }
        });
    }

}
