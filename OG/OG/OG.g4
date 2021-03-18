
grammar OG;

program: machine draw functionDeclaration* shapeDefinition*;
machineVariables : 'Xmin' '=' Number ',' 'Xmax' '=' Number ',' 'Ymin' '=' Number',' 'Ymax' '=' Number;
machine          : 'Machine' '.''WorkArea''.''size' '(' machineVariables ')'';';
draw             : 'draw' '{' (ID';')* '}';

//Shapes:
shapeDefinition     : 'shape' ID '{' body '}';
//body                : declaration* command* expression;
body: '{' (expression | declaration |  assignment |  functionCall | command)* '}'| '{' body '}' |  ; //Fix

//Basic declarations and assignments:
assignment          : ID '=' (ID |expression); //Byt ikke om på rækkefølgen! Et expression kan også indeholde ID, 
                                                // så myVar = a bliver evalueret som expression
                                                
declaration         : (numberDeclaration | pointDeclaration | booleanDeclaration)';' ;
booleanDeclaration  : 'bool' ID   '=' boolExpression;
numberDeclaration   : 'number' ID '=' (ID | mathExpression | valueReference); //Check val.ref
pointDeclaration    : 'point'  ID '=' ( coordinateReference | ID );
coordinateReference : '(' numberTuple ')';
numberTuple         : (Number | mathExpression | numberRefence) ',' (Number | mathExpression | numberRefence); //Overvej om man skal kunne skrive maths.

//Generel expressions:
expression      : (mathExpression | boolExpression);

boolExpression  :  (mathExpression BoolOperator mathExpression) | BooleanValue | boolExpression LogicOperator boolExpression | functionCall; //Overvej function call

mathExpression  : term   (('+' | '-') term)*;
term            : factor (('*' | '/') factor)*;
factor          : signedAtom ('^' signedAtom)*;
signedAtom      : /*signedAtom | '-' signedAtom |*/ atom;
atom             : Number | ID | '(' mathExpression ')' | functionCall; //Atom is a sub-equation


//Commands:
//Movement commands:
command         : iterationCommand | movementCommand;
movementCommand : (lineCommand | curveCommand)';';
lineCommand     : 'line' '.' 'from' '(' (numberTuple | ID)')' toCommand+;
curveCommand    : 'curve' '.' 'withAngle' '(' Number ')' '.' 'from' '('(numberTuple | ID)')' toCommand;
toCommand       : '.to''(' (numberTuple | ID) ')';

//Iteration commands:
iterationCommand: numberIteration | untilIteration;
numberIteration : 'repeat''('Number')' body 'repeat.end'; //Ret krop?
untilIteration  : 'repeat''.''until''('boolExpression')' body 'repeat.end';


//Functions: 
functionDeclaration     : returnFunctionDCL | voidFunctionDCL;
returnFunctionDCL       : 'function' typeWord ID parameterDeclarations '{' body returnStatement '}';

typeWord                : (PointDCLWord | BoolDCLWord | NumberDCLWord);

voidFunctionDCL         : 'function' 'void' ID parameterDeclarations '{' body '}';

parameterDeclarations   : '('parameters')';
parameters              :  (typeWord ID',')* typeWord ID | ;
functionCall            : ID '(' parameterList ')';
parameterList           : ( (ID | expression)',')* (ID | expression) | ;
returnStatement         : 'return' (ID | expression) ';';


numberRefence : Number | CoordinatePropRef; //Anything that evaluates to a number, but is not in itself a number.
valueReference: ID | Number | BooleanValue | CoordinatePropRef;



//RÆKKEFØLGE AF TOKENS//
//Sammensatte værdier 

//Tokens and help variables:
BooleanValue: 'true'| 'false';


Number: Integer|Float;
fragment Integer: [0-9]+ | '-'[0-9]+;
fragment Float : [0-9]+'.'[0-9]+ | '-'[0-9]+ | '-'[0-9]+'.'[0-9]+; // this is træls

WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines
COMMENT: '/*' .*? '*/' -> skip;


//Startwords
ShapeDCLWord: 'shape';
PointDCLWord: 'point';
BoolDCLWord : 'bool';
NumberDCLWord:'number';
DrawDCLWord:  'draw';

//CommandWords: 
WithAngle: 'withAngle';
Curve    : 'curve';
Line     : 'line';
To       : 'to';
From     : 'from';
RepeatStart: 'repeat';
RepeatEnd: 'repeat.end';
Until: 'until';
DOT: '.';

//Function specific words
FunctionStartWord : 'function';
FunctionReturnWord: 'return';
Void              : 'void';

//Operators for mathematics and expressions
LPAREN   : '('   ;
RPAREN   : ')'   ;

PLUS     : '+'   ;
MINUS    : '-'   ;
TIMES    : '*'   ;
DIV      : '/'   ;
POW      : '^'   ;

LogicOperator    :  AND | OR ;
BoolOperator     :  LT  | GT | EQ;
GT       : '>'   ;
LT       : '<'   ;
EQ       : '=='  ;
AND      : '&&'  ;
OR       : '||'  ;

Assign   : '=';

//Scopes and terminators;
OpenScope:  '{';
CloseScope: '}';
Terminator: ';';
Seperator: ',';

CoordinatePropRef: (ID'.x') | (ID'.y');
ID: [a-zA-Z]+[0-9a-zA-Z]*; //ID skal være nederst for ikke at overwrite alle de andre keywords.



