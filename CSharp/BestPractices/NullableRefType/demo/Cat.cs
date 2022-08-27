namespace demo
{
    public class DemoNullable
    {
        public int? goal { get; set; }
        public DemoNullable(int goal)
        {
            //this.goal.Value = goal;
            //Property or indexer 'int?.Value' cannot be assigned to -- it is read only
        }
        public DemoNullable()
        {
            
        }
        public void CallDisplay()
        {
            int? a = null;
            Display(a);
        }
        public void Display(int? goal)
        {
            if(goal != null)
            {
                System.Console.WriteLine("goal is not null");
            }
            else
            {
                System.Console.WriteLine("goal is nullable type reference");
            }
        }
    }
}