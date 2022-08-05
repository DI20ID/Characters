namespace Characters {
    public class Item : NotificationObject {

        public string? StoragePlace { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
       // public string? Worth { get; set; }
        private string? _Worth;
        public string? Worth {
            get {
                return _Worth;
            }
            set {
                _Worth = value; RaisePropertyChanged();
            }
        }
        public string? Count { get; set; }
        //public string? Weight { get; set; }
         private string? _Weigth;
         public string? Weigth { 
             get { return _Weigth; 
             } 
             set {
                _Weigth = value; RaisePropertyChanged(); 
             } 
         }
        public Item(string? storagePlace, string? worth, string? count, string? weight, string? name, string? description) {
            StoragePlace = storagePlace;
            Name = name;
            Worth = worth;
            Weigth = weight;
            Count = count;
            Description = description;
        }
        public Item() {
        }

    }
}
