package ejercicios;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentActivity;
import androidx.viewpager2.adapter.FragmentStateAdapter;

import com.example.materialdesign.R;

public class ViewPageAdapter extends FragmentStateAdapter {

    private static final int NUM_TABS = 4;

    public ViewPageAdapter(@NonNull FragmentActivity fragmentActivity) {
        super(fragmentActivity);
    }

    @NonNull
    @Override
    public Fragment createFragment(int position) {

        switch (position) {
            case 0:

                return ContenidoFragment.newInstance(
                        "Granjas -- Paz y tranquilidad",
                        R.raw.farming,
                        "GRANJAS");
            case 1:
                // Aventura
                return ContenidoFragment.newInstance(
                        "Aventura -- Explora nuevos mundos",
                        R.raw.zelda,
                        "AVENTURA!");
            case 2:
                // Deportes
                return ContenidoFragment.newInstance(
                        "Música -- Siente el ritmo!",
                        R.raw.music,
                        "MUSICA!");
            case 3:
                // Estrategia
                return ContenidoFragment.newInstance(
                        "Estrategia -- A pensar!",
                        R.raw.puzzles,
                        "PUZZLES");
            default:
                return new ContenidoFragment();
        }
    }

    @Override
    public int getItemCount() {
        return NUM_TABS;
    }
}

