package ejercicios;

import android.os.Bundle;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.viewpager2.widget.ViewPager2;

import com.example.materialdesign.R;
import com.google.android.material.appbar.MaterialToolbar;
import com.google.android.material.tabs.TabLayout;
import com.google.android.material.tabs.TabLayoutMediator;

public class Ej82 extends AppCompatActivity {
    private MaterialToolbar toolbar;
    private TabLayout tabLayout;
    private ViewPager2 viewPager;
    private ViewPageAdapter viewPagerAdapter;

    private final String[] titulosTabs = new String[]{"FARMING", "ADVENTURE", "MUSIC", "STRATEGY"};

    // Array de iconos que hemos añadido
    private final int[] iconosTabs = new int[] {
            R.drawable.ic_farm,
            R.drawable.ic_adventure,
            R.drawable.ic_music,
            R.drawable.ic_puzzle
    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_activity2);


        toolbar = findViewById(R.id.mainToolbar);
        tabLayout = findViewById(R.id.tabLayout);
        viewPager = findViewById(R.id.viewPager);


        setSupportActionBar(toolbar);


        viewPagerAdapter = new ViewPageAdapter(this);
        viewPager.setAdapter(viewPagerAdapter);


        new TabLayoutMediator(tabLayout, viewPager,
                (tab, position) -> {
                    tab.setText(titulosTabs[position]);
                    tab.setIcon(iconosTabs[position]);
                }).attach();
    }
}
