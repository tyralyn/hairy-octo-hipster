using System;

class mazeSolve {
	  public string getInput() {
	  	   Console.Write("Please enter name of file: ");
		   return Console.ReadLine();
	  }
	  public void imageTest() {
	  		 Console.WriteLine("anotherLine");
	  }
}


class Program {
	  static void Main() {
	  		 Console.WriteLine("line to write!");
			 mazeSolve m = new mazeSolve();
			 m.imageTest();
			 Console.WriteLine(m.getInput());
	  }

}