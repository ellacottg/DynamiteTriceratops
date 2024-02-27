namespace SpectreDispatcher {

    public class Character {

        private int energy;
        private int strength;
        private Item[] items;

        public int Energy {
            get {return energy;}
            set {energy = value;}
        }

        public int Strength {
            get {return strength;}
            set {strength = value;}
        }

        public Item[] Items {
            get {return items;}
            //set {items = new Item[value];}
            set {items = value;}
        }

    }

}