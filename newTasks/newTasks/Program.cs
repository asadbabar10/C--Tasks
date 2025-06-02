using System;

namespace newTasks
{
    public class Program
    {
        static void Main(string[] args)
        {

            Syntax syntax = new Syntax();
            syntax.syntaxTask();
            DataType dataTypes = new DataType();
            dataTypes.datatypeTask();
            //string result = dataTypes.datatypeTask();
            //Console.WriteLine(result);

            Variables variables = new Variables();
            variables.variablesTask();
            Operators op = new Operators();
            op.operatorsTask();
            Ifelse ifelse = new Ifelse();
            ifelse.FindAge();
            ifelse.CheckNum();
            Switches switches = new Switches();
            switches.switchTask();
            Loops loops = new Loops();
            loops.loopsTask();
            Arrays arrays = new Arrays();
            arrays.arraysTask();
            game games = new game();
            games.gameTask();

            Console.ReadKey();
        }
    }
}
