package com.example.listadosymenus.ejercicios;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.GridView;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.listadosymenus.R;
import com.example.listadosymenus.adapters.VersionAdapter;
import com.example.listadosymenus.pojos.Encapsulador;

import java.util.ArrayList;

public class Ej67 extends AppCompatActivity {

    GridView gv;
    TextView tvTitle;
    TextView tvDescription;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad7_layout);

        gv = findViewById(R.id.gridViewVersiones);
        tvTitle = findViewById(R.id.textViewTituloDetalle);
        tvDescription = findViewById(R.id.textViewDescripcionDetalle);


        ArrayList<Encapsulador> datos = new ArrayList<>();
        datos.add(new Encapsulador(R.drawable.donuts, "DONUTS", "El 15 de septiembre de 2009, fue lanzado el SDK de Android 1.6 Donut, basado en el núcleo Linux 2.6 .29.En la actualización se incluyen numerosas características nuevas.", true));
        datos.add(new Encapsulador(R.drawable.froyo, "FROYO", "El 20 de mayo de 2010, El SDK de Android 2.2 Froyo(Yogur helado) fue lanzado, basado en el núcleo Linux 2.6 .32.", false));
        datos.add(new Encapsulador(R.drawable.gingerbread, "GINGERBREAD", "El 6 de diciembre de 2010, el SDK de Android 2.3 Gingerbread(Pan de Jengibre) fue lanzado, basado en el núcleo Linux 2.6 .35.", false));
        datos.add(new Encapsulador(R.drawable.honeycomb, "HONEYCOMB", "El 22 de febrero de 2011, sale el SDK de Android 3.0 Honeycomb(Panal de Miel).Fue la primera actualización exclusiva para TV y tableta, lo que quiere decir que sólo es apta para TV y tabletas y no para teléfonos Android.", false));
        datos.add(new Encapsulador(R.drawable.icecream, "ICE CREAM", "El SDK para Android 4.0.0 Ice Cream Sandwich(Sándwich de Helado), basado en el núcleo de Linux 3.0 .1, fue lanzado públicamente el 12 de octubre de 2011. ", false));
        datos.add(new Encapsulador(R.drawable.jellybean, "JELLY BEAN", "Google anunció Android 4.1 Jelly Bean(Gomita Confitada o Gominola)en la conferencia del 30 de junio de 2012. Basado en el núcleo de linux 3.0 .31.", false));
        datos.add(new Encapsulador(R.drawable.kitkat, "KITKAT", "Su nombre se debe a la chocolatina KitKat, de la empresa internacional Nestlé.Posibilidad de impresión mediante WIFI.WebViews basadas en el motor de Chromium.", false));
        datos.add(new Encapsulador(R.drawable.lollipop, "LOLLIPOP", "Incluye Material Design, un diseño intrépido, colorido, y sensible interfaz de usuario para las experiencias coherentes e intuitivos en todos los dispositivos.", false));

        VersionAdapter adapter = new VersionAdapter(this, datos);

        gv.setAdapter(adapter);

        gv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                Encapsulador selected = datos.get(position);

                for (Encapsulador e : datos) {
                    e.setSeleccionado(false);
                }

                selected.setSeleccionado(true);
                tvTitle.setText(selected.getTitulo());
                tvDescription.setText(selected.getDescripcion());

                adapter.notifyDataSetChanged();

            }
        });
    }
}
