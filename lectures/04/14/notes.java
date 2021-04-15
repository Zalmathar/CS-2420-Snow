class Notes {
    public static void main(String[] args) {
        // A simple array could also be though of as a map.
        // With the index as the keys and the data in the array as the value
    }
}

class ArrayMap {
    private String[] map = new String[10];

    public String get(String key) {
        for (int i = 0; i < map.length; i++) { 
            if (map[i] == key) {
                return map[i];
            }
        }
        return null;
    }
}
