package fr.nekland.android.fideleapp;

import android.content.AsyncTaskLoader;

import java.util.ArrayList;
import android.content.Context;
import android.widget.Toast;

import com.turbomanage.httpclient.BasicHttpClient;
import com.turbomanage.httpclient.HttpResponse;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/**
 * Doesn't work.
 */
public class CardMenuLoader extends AsyncTaskLoader<ArrayList<String>> {

    public CardMenuLoader(Context context) {
        super(context);
    }

    @Override
    public ArrayList<String> loadInBackground() {
        ArrayList<String> menu = new ArrayList<String>();
        Toast.makeText(this.getContext(), "Foobar", Toast.LENGTH_LONG).show();

        // See https://github.com/turbomanage/basic-http-client
        BasicHttpClient http = new BasicHttpClient("http://10.0.2.2:8000");
        HttpResponse httpResponse = http.get("/cards.json", http.newParams());
        String jsonRaw = httpResponse.getBodyAsString();

        try {
            JSONArray cards = new JSONArray(jsonRaw);

            for (int i = 0; i < cards.length(); i++) {
                JSONObject card = cards.getJSONObject(i);
                menu.add(card.getString("name"));
            }

        } catch (JSONException e) {
            e.printStackTrace();
        }

        return menu;
    }
}
