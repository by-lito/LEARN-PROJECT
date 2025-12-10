package com.example.listadosymenus.adapters;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.example.listadosymenus.R;
import com.example.listadosymenus.pojos.Videogame;

import java.util.List;

public class VideogameAdapter extends ArrayAdapter<Videogame> {

    public VideogameAdapter(@NonNull Context context, @NonNull List<Videogame> objects) {
        super(context, 0, objects);
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {

        if (convertView == null) {
            convertView = LayoutInflater.from(getContext())
                    .inflate(R.layout.list_item_videogames_complex, parent, false);
        }

        Videogame vg = getItem(position);

        ImageView img = convertView.findViewById(R.id.imageViewVideogame);
        TextView title = convertView.findViewById(R.id.textViewNombre);
        TextView description = convertView.findViewById(R.id.textViewDescripcion);

        img.setImageResource(vg.getImagenRes());
        title.setText(vg.getNombre());
        description.setText(vg.getDescription());

        return convertView;
    }
}
