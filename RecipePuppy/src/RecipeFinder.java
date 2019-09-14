import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

import java.io.*;
import java.net.URL;
import java.nio.charset.Charset;
import java.util.ArrayList;
import java.util.Scanner;

public class RecipeFinder {
    private static ArrayList<Recipe> listOfRecipes=new ArrayList<>();
    private static ConsoleHelper consoleHelper=new ConsoleHelper();

    public static void main(String[] args) {
        consoleHelper.writeLine("Enter the ingredients separated by commas");
        String necessaryIngredients=consoleHelper.readLine();
        String nameIngredients = getNameIngredients(necessaryIngredients);
        try {
            for(JSONObject recipe:readFromUrl("http://www.recipepuppy.com/api/?i=" + nameIngredients+"&p=")){
                listOfRecipes.add(getNewRecipe(recipe));
            }
        }
        catch (ParseException e){

        }
        Recipe easiestRecipe=findBestRecipe();
        if(easiestRecipe!=null){
            consoleHelper.writeLine("The easiest recipe for requested ingredients is '"+easiestRecipe.getTitle()+"'");
            consoleHelper.writeLine("It contains only this ingredients '"+ getStringIngredients(easiestRecipe.getIngredients()));
            consoleHelper.writeLine("Link: "+easiestRecipe.getHref());
        }
        else{
            consoleHelper.writeLine("The recipe not found");
        }
        consoleHelper.writeLine("\nPress ENTER to proceed.\n");
        consoleHelper.readLine();
    }

    public static ArrayList<JSONObject> readFromUrl(String url) throws ParseException {
            ArrayList<JSONObject> recipesArr=new ArrayList<>();
            for (int i = 1; i <= 20; i++) {
                try (InputStream is=new URL(url+i).openStream())
                {
                    BufferedReader reader=new BufferedReader(new InputStreamReader(is,Charset.forName("UTF-8")));
                    String jsonText=readAll(reader);
                    JSONObject jo=(JSONObject) new JSONParser().parse(jsonText);
                    recipesArr.addAll((JSONArray) jo.get("results"));
                }
                catch (IOException e){

                }
            }
            return recipesArr;
    }

    public static String readAll(Reader reader) throws IOException{
        StringBuilder builder=new StringBuilder();
        while (reader.ready())
        {
            builder.append((char)reader.read());
        }
        return builder.toString();
    }

    public static String getStringIngredients(String[] arrayOfIngredients){
        String ingredients=new String();
        for(int i=0;i<arrayOfIngredients.length-1;i++){
            ingredients+=arrayOfIngredients[i]+", ";
        }
        ingredients+=arrayOfIngredients[arrayOfIngredients.length-1]+"'";
        return ingredients;
    }

    public static String getNameIngredients(String necessaryIngredients){
        return necessaryIngredients.replaceAll(" ","%20");
    }

    public static Recipe getNewRecipe(JSONObject recipe){
        String[] sts=recipe.get("title").toString().split("\n");
        String title=new String();
        for(String string:sts)
        {
            title+=string;
        }
        String href=recipe.get("href").toString();
        String[] ingredients=recipe.get("ingredients").toString().split(", ");
        return new Recipe(title,href,ingredients);
    }

    public static Recipe findBestRecipe(){
        Recipe theEasiestRecipe=null;
        int minSize=Integer.MAX_VALUE;
        for(Recipe recipe:listOfRecipes){
            if (recipe.getNumberOfIngredients()<minSize){
                minSize=recipe.getNumberOfIngredients();
                theEasiestRecipe=recipe;
            }
        }
        return theEasiestRecipe;
    }
}
