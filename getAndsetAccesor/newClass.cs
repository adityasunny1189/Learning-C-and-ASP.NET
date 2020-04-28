using System;

namespace getAndsetAccesor {
    class People {
        private string name;
        public string Name {
            get {return name;}
            set {name = value;}
        }
        public void print() {
            Console.WriteLine($"Hello {this.name}");
        }
    }
}