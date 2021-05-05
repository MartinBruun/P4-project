using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting.Visitors;
using OG.Compiler;

namespace Tests
{
    public class MathNodeReducerTest
    {
        [TestCase(0,2)]
        [TestCase(1,0)]
        [TestCase(2,1)]
        [TestCase(2,2)]
        [TestCase(2,3)]
        [TestCase(2,4)]
        [TestCase(2,5)]
        [TestCase(2,6)]
        [TestCase(4,2)]
        [TestCase(5,0.5)]
        [TestCase(4,0.5)]
        [TestCase(16,0.5)]
        [TestCase(16,-2)]
        [TestCase(-4,0.5)]
        [TestCase(-2,3)]
        [TestCase(16,-0.5)]
        [TestCase(0,0)]
        [TestCase(0,1)]
        [TestCase(-1,-1)]
      
        public void Power_Should_Be_Calculated_Correctly(double x, double y)
        {
            //Power node constructor takes first RHS and then LHS
            PowerNode node = new PowerNode(new NumberNode(y), new NumberNode(x));
            MathNodeReducer mathReducer = new MathNodeReducer(new SymbolTable(), new List<SemanticError>());
            Assert.AreEqual(Math.Pow(x,y),mathReducer.ReduceToNumberNode(node).NumberValue);
        }
        
        [TestCase(0,2,5)]
        [TestCase(1,0,2)]
        [TestCase(2,1,6)]
        [TestCase(2,2,8)]
        [TestCase(2,4,9)]
        [TestCase(2,4, 28)]
        [TestCase(2,5,13)]
        [TestCase(2,6,2)]
        [TestCase(4,2, -5)]
        [TestCase(5,0.5, 3)]
        [TestCase(4,0.5, 19)]
        [TestCase(16,0.5, 12)]
        [TestCase(16,-2, 0)]
        [TestCase(-4,0.5,-1)]
        [TestCase(-2,3, -2)]
        [TestCase(16,-0.5, 15)]
        [TestCase(0,0, 3)]
        [TestCase(0,1, 1024)]
        [TestCase(-1,-1, -1023)]
      
        public void Power__With_Addition_Should_Be_Calculated_Correctly(double x, double y, double z)
        {
            //Power node constructor takes first RHS and then LHS
            PowerNode node = new PowerNode(new AdditionNode (new NumberNode(y), new NumberNode(z)), new NumberNode(x));
            MathNodeReducer mathReducer = new MathNodeReducer(new SymbolTable(), new List<SemanticError>());
            Assert.AreEqual(Math.Pow(x,y+z),mathReducer.ReduceToNumberNode(node).NumberValue);
        }
        
        [TestCase(0,2,5)]
        [TestCase(1,0,2)]
        [TestCase(2,1,6)]
        [TestCase(2,2,8)]
        [TestCase(2,4,9)]
        [TestCase(2,4, 28)]
        [TestCase(2,5,13)]
        [TestCase(2,6,2)]
        [TestCase(4,2, -5)]
        [TestCase(5,0.5, 3)]
        [TestCase(4,0.5, 19)]
        [TestCase(16,0.5, 12)]
        [TestCase(16,-2, 0)]
        [TestCase(-4,0.5,-1)]
        [TestCase(-2,3, -2)]
        [TestCase(16,-0.5, 15)]
        [TestCase(0,0, 3)]
        [TestCase(0,1, 1024)]
        [TestCase(-1,-1, -1023)]
        public void Power__With_multiplication_Should_Be_Calculated_Correctly(double x, double y, double z)
        {
            //Power node constructor takes first RHS and then LHS
            PowerNode node = new PowerNode(new MultiplicationNode (new NumberNode(y), new NumberNode(z)), new NumberNode(x));
            MathNodeReducer mathReducer = new MathNodeReducer(new SymbolTable(), new List<SemanticError>());
            Assert.AreEqual(Math.Pow(x,y*z),mathReducer.ReduceToNumberNode(node).NumberValue);
        }
        
        [TestCase(0,2,5)]
        [TestCase(1,0,2)]
        [TestCase(2,1,6)]
        [TestCase(2,2,8)]
        [TestCase(2,4,9)]
        [TestCase(2,4, 28)]
        [TestCase(2,5,13)]
        [TestCase(2,6,2)]
        [TestCase(4,2, -5)]
        [TestCase(5,0.5, 3)]
        [TestCase(4,0.5, 19)]
        [TestCase(16,0.5, 12)]
        [TestCase(16,-2, 0)]
        [TestCase(-4,0.5,-1)]
        [TestCase(-2,3, -2)]
        [TestCase(16,-0.5, 15)]
        [TestCase(0,0, 3)]
        [TestCase(0,1, 1024)]
        [TestCase(-1,-1, -1023)]
        public void Power__With_Division_Should_Be_Calculated_Correctly(double x, double y, double z)
        {
            //Power node constructor takes first RHS and then LHS
            //Same goes for division
            PowerNode node = new PowerNode(new DivisionNode (new NumberNode(y), new NumberNode(z)), new NumberNode(x));
            MathNodeReducer mathReducer = new MathNodeReducer(new SymbolTable(), new List<SemanticError>());
            Assert.AreEqual(Math.Pow(x,z/y),mathReducer.ReduceToNumberNode(node).NumberValue);
        }
        
        [TestCase(0,2,5)]
        [TestCase(1,0,2)]
        [TestCase(2,1,6)]
        [TestCase(2,2,8)]
        [TestCase(2,4,9)]
        [TestCase(2,4, 28)]
        [TestCase(2,5,13)]
        [TestCase(2,6,2)]
        [TestCase(4,2, -5)]
        [TestCase(5,0.5, 3)]
        [TestCase(4,0.5, 19)]
        [TestCase(16,0.5, 12)]
        [TestCase(16,-2, 0)]
        [TestCase(-4,0.5,-1)]
        [TestCase(-2,3, -2)]
        [TestCase(16,-0.5, 15)]
        [TestCase(0,0, 3)]
        [TestCase(0,1, 1024)]
        [TestCase(-1,-1, -1023)]
        public void Power__With_Subtraction_Should_Be_Calculated_Correctly(double x, double y, double z)
        {
            //Power node constructor takes first RHS and then LHS
            //Same goes for subtraction
            PowerNode node = new PowerNode(new SubtractionNode (new NumberNode(y), new NumberNode(z)), new NumberNode(x));
            MathNodeReducer mathReducer = new MathNodeReducer(new SymbolTable(), new List<SemanticError>());
            Assert.AreEqual(Math.Pow(x,z-y),mathReducer.ReduceToNumberNode(node).NumberValue);
        }
        
        [TestCase(0,2,5)]
        [TestCase(1,0,2)]
        [TestCase(2,1,6)]
        [TestCase(2,2,8)]
        [TestCase(2,4,9)]
        [TestCase(2,4, 28)]
        [TestCase(2,5,13)]
        [TestCase(2,6,2)]
        [TestCase(4,2, -5)]
        [TestCase(5,0.5, 3)]
        [TestCase(4,0.5, 19)]
        [TestCase(16,0.5, 12)]
        [TestCase(16,-2, 0)]
        [TestCase(-4,0.5,-1)]
        [TestCase(-2,3, -2)]
        [TestCase(16,-0.5, 15)]
        [TestCase(0,0, 3)]
        [TestCase(0,1, 1024)]
        [TestCase(-1,-1, -1023)]
        public void Power__With_Power_Should_Be_Calculated_Correctly(double x, double y, double z)
        {
            //Power node constructor takes first RHS and then LHS
            //Same goes for subtraction
            PowerNode node = new PowerNode(new PowerNode (new NumberNode(y), new NumberNode(z)), new NumberNode(x));
            MathNodeReducer mathReducer = new MathNodeReducer(new SymbolTable(), new List<SemanticError>());
            Assert.AreEqual(Math.Pow(x,Math.Pow(z,y)),mathReducer.ReduceToNumberNode(node).NumberValue);
        }
        
        [TestCase(0)      ]
        [TestCase(-0)     ]
        [TestCase(1)      ]
        [TestCase(-1)     ]
        [TestCase(2)      ]
        [TestCase(-2)     ]
        [TestCase(3)      ]
        [TestCase(-3)     ]
        [TestCase(100)    ]
        [TestCase(-100)   ]
        [TestCase(255)    ]
        [TestCase(-255)   ]
        [TestCase(10.000) ]
        [TestCase(-10.000)]
        [TestCase(1)]
        public void Deep_Multiplication_Does_Not_Fail(double x)
        {
            //Power node constructor takes first RHS and then LHS
            //Same goes for subtraction
            MultiplicationNode n = new MultiplicationNode
            (
                new MultiplicationNode
                (
                    new MultiplicationNode(new MultiplicationNode(new NumberNode(x), new NumberNode(x)),
                        new NumberNode(x)),
                    new MultiplicationNode(new MultiplicationNode(new NumberNode(x), new NumberNode(x)),
                        new NumberNode(x))
                ),

                new MultiplicationNode
                (
                    new MultiplicationNode(new MultiplicationNode(new NumberNode(x), new NumberNode(x)),
                        new NumberNode(x)),
                    new MultiplicationNode(new MultiplicationNode(new NumberNode(x), new NumberNode(x)),
                        new NumberNode(x))
                )
                );

            MathNodeReducer mathReducer = new MathNodeReducer(new SymbolTable(), new List<SemanticError>());
            
            Assert.DoesNotThrow(() =>
            {
                mathReducer.ReduceToNumberNode(n);
            });
        }
        
        [TestCase(0,2)]
        [TestCase(1,0)]
        [TestCase(2,1)]
        [TestCase(2,2)]
        [TestCase(2,3)]
        [TestCase(2,4)]
        [TestCase(2,5)]
        [TestCase(2,6)]
        [TestCase(4,2)]
        [TestCase(5,0.5)]
        [TestCase(4,0.5)]
        [TestCase(16,0.5)]
        [TestCase(16,-2)]
        [TestCase(-4,0.5)]
        [TestCase(-2,3)]
        [TestCase(16,-0.5)]
        [TestCase(0,0)]
        [TestCase(0,1)]
        [TestCase(-1,-1)]
      
        public void Addition_Should_Be_Calculated_Correctly(double x, double y)
        {
            //Power node constructor takes first RHS and then LHS
            AdditionNode node = new AdditionNode(new NumberNode(y), new NumberNode(x));
            MathNodeReducer mathReducer = new MathNodeReducer(new SymbolTable(), new List<SemanticError>());
            Assert.AreEqual(x+y, mathReducer.ReduceToNumberNode(node).NumberValue);
        }
        
        [TestCase(0,2)]
        [TestCase(1,0)]
        [TestCase(2,1)]
        [TestCase(2,2)]
        [TestCase(2,3)]
        [TestCase(2,4)]
        [TestCase(2,5)]
        [TestCase(2,6)]
        [TestCase(4,2)]
        [TestCase(5,0.5)]
        [TestCase(4,0.5)]
        [TestCase(16,0.5)]
        [TestCase(16,-2)]
        [TestCase(-4,0.5)]
        [TestCase(-2,3)]
        [TestCase(16,-0.5)]
        [TestCase(0,0)]
        [TestCase(0,1)]
        [TestCase(-1,-1)]
      
        public void Subtraction_Should_Be_Calculated_Correctly(double x, double y)
        {
            //Power node constructor takes first RHS and then LHS
            SubtractionNode node = new(new NumberNode(y), new NumberNode(x));
            MathNodeReducer mathReducer = new MathNodeReducer(new SymbolTable(), new List<SemanticError>());
            Assert.AreEqual(x-y, mathReducer.ReduceToNumberNode(node).NumberValue);
        }
        
        [TestCase(0,2)]
        [TestCase(1,0)]
        [TestCase(2,1)]
        [TestCase(2,2)]
        [TestCase(2,3)]
        [TestCase(2,4)]
        [TestCase(2,5)]
        [TestCase(2,6)]
        [TestCase(4,2)]
        [TestCase(5,0.5)]
        [TestCase(4,0.5)]
        [TestCase(16,0.5)]
        [TestCase(16,-2)]
        [TestCase(-4,0.5)]
        [TestCase(-2,3)]
        [TestCase(16,-0.5)]
        [TestCase(0,0)]
        [TestCase(0,1)]
        [TestCase(-1,-1)]
        public void Division_Should_Be_Calculated_Correctly(double x, double y)
        {
            //Power node constructor takes first RHS and then LHS
            DivisionNode node = new(new NumberNode(y), new NumberNode(x));
            MathNodeReducer mathReducer = new MathNodeReducer(new SymbolTable(), new List<SemanticError>());
            Assert.AreEqual(x/y, mathReducer.ReduceToNumberNode(node).NumberValue);
        }
        
        [TestCase(0,2)]
        [TestCase(1,0)]
        [TestCase(2,1)]
        [TestCase(2,2)]
        [TestCase(2,3)]
        [TestCase(2,4)]
        [TestCase(2,5)]
        [TestCase(2,6)]
        [TestCase(4,2)]
        [TestCase(5,0.5)]
        [TestCase(4,0.5)]
        [TestCase(16,0.5)]
        [TestCase(16,-2)]
        [TestCase(-4,0.5)]
        [TestCase(-2,3)]
        [TestCase(16,-0.5)]
        [TestCase(0,0)]
        [TestCase(0,1)]
        [TestCase(-1,-1)]
        public void Multiplication_Should_Be_Calculated_Correctly(double x, double y)
        {
            //Power node constructor takes first RHS and then LHS
            MultiplicationNode node = new(new NumberNode(y), new NumberNode(x));
            MathNodeReducer mathReducer = new MathNodeReducer(new SymbolTable(), new List<SemanticError>());
            Assert.AreEqual(x*y, mathReducer.ReduceToNumberNode(node).NumberValue);
        }
        
        [TestCase(0)      ]
        [TestCase(-0)     ]
        [TestCase(1)      ]
        [TestCase(-1)     ]
        [TestCase(2)      ]
        [TestCase(-2)     ]
        [TestCase(3)      ]
        [TestCase(-3)     ]
        [TestCase(100)    ]
        [TestCase(-100)   ]
        [TestCase(255)    ]
        [TestCase(-255)   ]
        [TestCase(10.000) ]
        [TestCase(-10.000)]
        [TestCase(1)]
        public void NumberNode_Should_Hold_Correct_Numerical_Value(double x)
        {
            MathNodeReducer mathReducer = new MathNodeReducer(new SymbolTable(), new List<SemanticError>());
            Assert.AreEqual(x, mathReducer.ReduceToNumberNode(new NumberNode(x)).NumberValue);
        }
    }
}