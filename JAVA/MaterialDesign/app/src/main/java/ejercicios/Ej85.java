package ejercicios;

import android.os.Bundle;
import android.view.GestureDetector;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.materialdesign.R;

import java.util.ArrayList;
import java.util.List;

public class Ej85 extends AppCompatActivity {
    private RecyclerView reciclador;
    private RecyclerView.Adapter adaptador;
    private RecyclerView.LayoutManager gestor;
    private List<Encapsulador> datos;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_activity5);

        datos = new ArrayList<>();

        datos.add(new Encapsulador(R.drawable.mario, "SUPER MARIO BROS.", "Lanzado en 1985 para la NES, definió el género de plataformas y es uno de los juegos más influyentes de la historia."));
        datos.add(new Encapsulador(R.drawable.zelda, "THE LEGEND OF ZELDA", "Una aventura de rol y acción de 1986 que revolucionó la exploración en videojuegos con su vasto mundo de Hyrule."));
        datos.add(new Encapsulador(R.drawable.pacman, "PAC-MAN", "El clásico juego de arcade de 1980 donde controlas a un personaje que come puntos mientras evita a cuatro fantasmas de colores."));
        datos.add(new Encapsulador(R.drawable.tetris, "TETRIS", "Un juego de lógica soviético de 1984 que consiste en encajar bloques que caen. Famoso por su adictiva jugabilidad."));
        datos.add(new Encapsulador(R.drawable.dk, "DONKEY KONG", "Un hito de 1981 de Nintendo, donde Mario (antes llamado Jumpman) debe rescatar a Pauline del gorila gigante."));
        datos.add(new Encapsulador(R.drawable.spaceinvaders, "SPACE INVADERS", "Uno de los primeros juegos 'shoot 'em up' de 1978, donde debes proteger la Tierra de una invasión alienígena."));

        reciclador = findViewById(R.id.reciclador); // Uso más moderno de findViewById
        reciclador.setHasFixedSize(true);

        gestor = new LinearLayoutManager(this);
        reciclador.setLayoutManager(gestor);

        adaptador = new AdaptadorCarta(datos);
        reciclador.setAdapter(adaptador);

        reciclador.addOnItemTouchListener(new RecyclerView.OnItemTouchListener() {
            GestureDetector gestureDetector = new GestureDetector(getApplicationContext(), new
                    GestureDetector.SimpleOnGestureListener() {
                        @Override
                        public boolean onSingleTapUp(MotionEvent e) {
                            return true;
                        }
                    });

            @Override
            public boolean onInterceptTouchEvent(@NonNull RecyclerView rv, @NonNull MotionEvent e) {
                View hijo = rv.findChildViewUnder(e.getX(), e.getY());

                if (hijo != null && gestureDetector.onTouchEvent(e)) {
                    int position = rv.getChildAdapterPosition(hijo);
                    Toast.makeText(getApplicationContext(),
                            "¡Iniciando " + datos.get(position).get_textotitulo() + "!",
                            Toast.LENGTH_SHORT).show();
                }
                return false;
            }

            @Override
            public void onTouchEvent(@NonNull RecyclerView rv, @NonNull MotionEvent e) {
            }

            @Override
            public void onRequestDisallowInterceptTouchEvent(boolean disallowIntercept) {
            }
        });
    }
}
