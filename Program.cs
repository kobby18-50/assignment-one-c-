//  See https://aka.ms/new-console-template for more information
//  See https://aka.ms/new-console-template for more information


  using System;
  namespace Project_one{
    class AXON_project{
    static void Main(string[] args){


        bool finished = true;

      try
      {
        do{

        Menu();

       int option = Convert.ToInt32(Console.ReadLine());

       
        switch(option){
          case 1:
          System.Console.WriteLine("You chose {0} Odd and even numbers", option);
          Odd_Even_Generator();
          break;

          case 2:
          System.Console.WriteLine("You chose {0} Grading System", option);
          Grading_System();
          break;

          case 3:
          System.Console.WriteLine("You chose {0} Hello World", option);
          Hello_World();
          break;

          case 4:
          System.Console.WriteLine("You chose {0} Multiples Generator", option);
          Multiples_Generator();
          break;

          case 5:
          System.Console.WriteLine("You chose {0} Perfect number", option);
          Perfect_Number_Generator();
          break;

          case 6:
          System.Console.WriteLine("You chose {0} Palindrome", option);
          Palindrome();
          break;

          default:
          Console.WriteLine("Enter a valid number 1-6");
          break;
       }
        System.Console.WriteLine("");
       System.Console.WriteLine("Do you want to restart? ('y/n') ");
       string control = Console.ReadLine();

       if(control == "y"){
        finished = false;
       Console.Clear();
       }else{
        finished = true;
        System.Console.WriteLine("Thanks for using KNet software");
       }
      }while(!finished);
      }
      catch (System.Exception)
      {
        
        System.Console.WriteLine("ERROR 111 : Input was not in correct format, The program will end now!");
      }

    }
     static void Menu(){
      System.Console.WriteLine("");
      Console.WriteLine("===================================================CHOOSE FROM THE TASKS BELOW========================================");
      Console.WriteLine("1. Odd and even numbers");
      Console.WriteLine("2. Grading System");
      Console.WriteLine("3. Hello World");
      Console.WriteLine("4. Multiples generator");
      Console.WriteLine("5. Perfect number ");
      Console.WriteLine("6. Palindrome");
      System.Console.WriteLine("");
      Console.WriteLine("Choose from the list above ");
    }

  // Functions
    static void Odd_Even_Generator(){
      System.Console.WriteLine("");
      
      try
      {
      System.Console.WriteLine("Enter number here: ");
      int number = Convert.ToInt32(Console.ReadLine());
      int value = number % 2;

      if (value == 1){
        System.Console.WriteLine("The number - {0} is odd", number);
      }else
      {
        System.Console.WriteLine("The number - {0} is even", number);
        
      }
        
      }
      catch (System.Exception)
      {
        
        System.Console.WriteLine("ERROR 222: Enter a number or input string was invalid");
      }

    }
    static void Grading_System(){

      try
      {
        Console.WriteLine("Enter score here (0-100)");
        int score = Convert.ToInt32(Console.ReadLine());

        if (score >= 70 && score <= 100){
          System.Console.WriteLine("Grade is 'A' ");
        }
        else if(score >= 60 && score < 70){
          System.Console.WriteLine("Grade is 'B' ");
        }
        else if(score >= 50 && score < 60){
          System.Console.WriteLine("Grade is 'C' ");
        }
        else if(score >= 40 && score < 50){
          System.Console.WriteLine("Grade is 'D' ");
        }
        else if(score >=0 && score < 40 ){
          System.Console.WriteLine("Grade is 'E' ");
        }

        else
        {
          System.Console.WriteLine("Try again with a valid number");
        }
      }
      catch (System.Exception)
      {
        
        System.Console.WriteLine("ERROR CODE 333 : Enter a number or input was not valid");
      }

    }

    static void Hello_World(){
        System.Console.WriteLine("Hello World");
    }

    static void Multiples_Generator(){
      System.Console.WriteLine("");

      try
      {
        Console.WriteLine("Enter a number to get the multiples");
        int number = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("The multiples of {0} are : ", number);

        for (int i = 1; i <= 10; i++){
          System.Console.Write((number * i) + " ");
        }

      }
      catch (System.Exception)
      {
        System.Console.WriteLine("ERROR CODE 444 : Enter a valid input next time");
      }
    }

    static void Perfect_Number_Generator(){
      try
      {
        int sum = 0;
        Console.WriteLine("Enter number here: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.Write("The factors of {0} are :  ", num);

        // loop for perfect number
        for (int index = 1; index < num; index++){
          // checking if the number's quotient is 0
          if (num % index == 0)
          {
            System.Console.Write(index + " ");
            sum = sum + index;
          }
        }
        System.Console.WriteLine("");

        System.Console.WriteLine("The sum of the factors is {0}  ", sum);

        // checking if the number equals the sum

        if (sum == num)
        {
          System.Console.WriteLine("{0} is a perfect number", num);
        }else
        {
          System.Console.WriteLine("{0} is not a perfect number", num);
        }

      }
      catch (System.Exception)
      {
        
        System.Console.WriteLine("ERROR CODE 555 : There are only four perfect numbers ");
      }
    }

    static void Palindrome(){
      try
      {
        int result = 0;
        Console.WriteLine("Enter number here");
        int number = Convert.ToInt32(Console.ReadLine());
        int quotient = number;

        while (quotient != 0)
        {
          // a number divided by 10 will give the quotient and the remainder
         // it can be reversed by adding the remainder to the quotient
         int remainder = quotient % 10;
          result = result * 10 + remainder;
          quotient = quotient / 10;
        }
        if (result == number){
          System.Console.WriteLine("Number is a palindrome");
        }
        else
        {
          System.Console.WriteLine("Number is not a palindrome");
          
        }
      }
      catch (System.Exception)
      {
        
        Console.WriteLine("ERROR 666");
      }
    }

    
  }
        
  }












    
    
    























