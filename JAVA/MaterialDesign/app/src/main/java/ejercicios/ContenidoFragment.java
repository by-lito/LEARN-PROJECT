package ejercicios;

import android.os.Bundle;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.materialdesign.R;
import com.google.android.material.button.MaterialButton;

public class ContenidoFragment extends Fragment {

    private static final String ARG_TEXTO = "arg_texto";
    private static final String ARG_DRAWABLE_ID = "arg_drawable_id";
    private static final String ARG_TOAST_MSG = "arg_toast_msg";
    private String texto;
    private int drawableId;
    private String toastMsg;

    public static ContenidoFragment newInstance(String texto, int drawableId, String toastMsg) {
        ContenidoFragment fragment = new ContenidoFragment();
        Bundle args = new Bundle();
        args.putString(ARG_TEXTO, texto);
        args.putInt(ARG_DRAWABLE_ID, drawableId);
        args.putString(ARG_TOAST_MSG, toastMsg);
        fragment.setArguments(args);
        return fragment;
    }

    @Override
    public void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        if (getArguments() != null) {
            texto = getArguments().getString(ARG_TEXTO);
            drawableId = getArguments().getInt(ARG_DRAWABLE_ID);
            toastMsg = getArguments().getString(ARG_TOAST_MSG);
        }
    }

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container,
                             @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.fragment_content1, container, false);
    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);
        ImageView imageView = view.findViewById(R.id.fragment_image);
        TextView textView = view.findViewById(R.id.fragment_text);
        MaterialButton button = view.findViewById(R.id.fragment_button);

        if (texto != null) {
            textView.setText(texto);
        }
        if (drawableId != 0) {
            imageView.setImageResource(drawableId);
        }

        button.setOnClickListener(v -> {
            if (toastMsg != null && getContext() != null) {
                Toast.makeText(getContext(), toastMsg, Toast.LENGTH_SHORT).show();
            }
        });
    }
}

