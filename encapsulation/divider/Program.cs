class Program {
    static void Main(string[] args) {
        
        var divider =  new IntegerDivision();
        divider.lhs = 10;
        divider.rhs = 1;
        divider.DisplayResult();

        divider.lhs = 0;
        divider.rhs = 100;
        divider.DisplayResult();

        divider.lhs = 5;
        divider.rhs = 0;
        divider.DisplayResult();

        divider.lhs = 25;
        divider.rhs = 5;
        divider.DisplayResult();
    }
}

class IntegerDivision {
    public int lhs = 1;
    public int rhs = 1;

    public int Result() {
        return lhs / rhs;
    }

    public void DisplayResult() {
        var result = Result();
        Console.WriteLine($"{lhs} divided by {rhs} is {result}");
    }
}
