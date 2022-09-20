Console.WriteLine("What is your grade percent?");
string? grade_string = Console.ReadLine();
int grade = Int32.Parse(grade_string ?? "0");
string letter_grade = "F";

if (grade >= 90) {
    letter_grade = "A";
} else if (grade >= 80) {
    letter_grade = "B";
} else if (grade >= 70) {
    letter_grade = "C";
} else if (grade >= 60) {
    letter_grade = "D";
}

Console.WriteLine($"Your letter grade is {letter_grade}");

if (letter_grade == "A" || letter_grade == "B" || letter_grade == "C") {
    Console.WriteLine("Well done, you passed!");
} else {
    Console.WriteLine("FAILURE");
}