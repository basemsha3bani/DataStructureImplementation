
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack.Implementation;
using TestProject.StackPracticeProblem;

namespace TestProject
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void countStackOverLapTest()
        {
            LinkedListStackImplemntation x = new LinkedListStackImplemntation();
            x.push(1);
            x.push(2);
            x.pop();
            ArrayStackImplementation y = new ArrayStackImplementation();
            y.push(1);
            y.push(2);  
            y.pop();

           var z= StackPracticeProblem.StackOverLapCounter.countStackOverLap(x, y);
            Assert.AreEqual(1,z);


            
            //\d{2}[*][+]\d{2}
        }
        [TestMethod]
        public void evaluatePostFixTest()
        {
             string prefixExpression = "2*3+4*5-9";
            
            PostFixGenerator postFixEvaluation = new PostFixGenerator();
            string postfixExpression =  postFixEvaluation.GeneratePostfix(prefixExpression);
            var result = new PostFixEvaluator().EvaluatePostFix(postfixExpression);
          
             result = new PostFixEvaluator().EvaluatePostFix(postfixExpression);

            Assert.AreEqual("17", result);

            prefixExpression = "(5+3)*(6-4)/((4-2)*(3+1))";
            postfixExpression=new PostFixGenerator().GeneratePostfix(prefixExpression);
            

            result = new PostFixEvaluator().EvaluatePostFix(postfixExpression);
            Assert.AreEqual("2", result);
        }
        
    }
}
