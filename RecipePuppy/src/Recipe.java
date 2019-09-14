public class Recipe {
    private String title;
    private String href;
    private String[] ingredients;

    public Recipe(String title, String href, String[] ingredients) {
        this.title = title;
        this.href = href;
        this.ingredients = ingredients;
    }

    public String getTitle() {
        return title;
    }

    public String getHref() {
        return href;
    }

    public String[] getIngredients() {
        return ingredients;
    }

    public int getNumberOfIngredients() {
        return ingredients.length;
    }
}
