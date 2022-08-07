namespace AccessModifierTutorial
{
    class Animal
    {
        private string name;

        // private constructor
        private Animal(string name)
        {
            this.name = name;
        }
        
        public string GetName()
        {
            return this.name;
        }
    }
}