package ejercicios;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.materialdesign.R;

import java.util.List;

public class AdaptadorCarta extends RecyclerView.Adapter<AdaptadorCarta.miHolder> {

    private List<Encapsulador> entradas;

    public AdaptadorCarta(List<Encapsulador> entradas) {
        this.entradas = entradas;
    }

    public static class miHolder extends RecyclerView.ViewHolder {
        public ImageView imagen;
        public TextView titulo,texto;

        public miHolder(View vista) {
            super(vista);
            // Enlazar con el XML
            imagen = (ImageView) vista.findViewById(R.id.imagen);
            titulo = (TextView) vista.findViewById(R.id.titulo);
            texto = (TextView) vista.findViewById(R.id.texto);
        }
    }

    @NonNull
    @Override
    public miHolder onCreateViewHolder(@NonNull ViewGroup viewGroup, int viewType) {
        View v = LayoutInflater.from(viewGroup.getContext())
                .inflate(R.layout.carta, viewGroup, false);
        return new miHolder(v);
    }

    @Override
    public void onBindViewHolder(@NonNull miHolder viewHolder, int i) {

        Encapsulador item = entradas.get(i);

        viewHolder.imagen.setImageResource(item.get_idImagen());
        viewHolder.titulo.setText(item.get_textotitulo());
        viewHolder.texto.setText(item.get_textoContenido());
    }

    @Override
    public int getItemCount() {
        return entradas.size();
    }
}
