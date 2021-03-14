
grammar OG;

program: machine draw functionDeclaration* shapeDefinition*;
machineVariables : Number ',' Number ',' Number',' Number;
machine          : 'Machine' '.WorkArea''.size' '(' machineVariables ')'';';
draw             : 'draw' '{' (ID';')* '}';

//Shapes:
shapeDefinition     : 'shape' ID '{' body '}';
body                : declaration* command* expression;

//Basic declarations and assignments:
declaration         : (numberDeclaration | pointDeclaration | booleanDeclaration)';';
numberDeclaration   : 'number' ID '=' mathExpression | valueReference;
pointDeclaration    : 'point'  ID '=' ( coordinateReference | ID );
booleanDeclaration  : 'bool'   ID '=' boolExpression;
coordinateReference : '(' numberTuple ')';
numberTuple         : (mathExpression | numberRefence) ',' (mathExpression | numberRefence);
assignment          : ID '=' (expression | ID);

//Generel expressions:
expression      : (mathExpression* | boolExpression*);

boolExpression  : mathExpression BoolOperator mathExpression;
BoolOperator    :  '==' | '>' | '<';

mathExpression  : term   (('+' | '-') term)*;
term            : factor (('*' | '/') factor)*;
factor          : signedAtom ('^' signedAtom)*;
signedAtom      : '+' signedAtom | '-' signedAtom | atom;
atom             : Number | variableReference | '(' mathExpression ')'; //Atom is a sub-equation
variableReference: ID;


//Commands:
//Movement commands:
command         : iterationCommand | movementCommand | functionCall;
movementCommand : (lineCommand | curveCommand)';';
lineCommand     : 'line''.from' '(' (numberTuple | ID)')' toCommand+;
toCommand       : '.to''(' (numberTuple | ID) ')';
curveCommand    : 'curve' '.withAngle''(' Number ')' '.from''('(numberTuple | ID)')' toCommand;

//Iteration commands:
iterationCommand: numberIteration | untilIteration;
numberIteration : 'repeat''('Integer')' body 'repeat''.end';
untilIteration  : 'repeat''.until''('boolExpression')' body 'repeat''.end';


//Functions: 
functionDeclaration     : returnFunctionDCL | voidFunctionDCL;
returnFunctionDCL       : 'function' Type ID parameterDeclerations '{' body returnStatement '}';
voidFunctionDCL         : 'function' 'void' ID parameterDeclerations '{' body '}';
parameterDeclerations   : '('parameters')';
parameters              : Type ID | (Type ID',')+ Type ID  | ;
parameterList           : (ID | expression);
functionCall            : ID '(' parameterList ')'';';
returnStatement         : 'return' (expression | valueReference) ';';


//Tokens and help variables:
coordinatePropertyValue: ID'.x' | ID'.y';
numberRefence : Number | coordinatePropertyValue; //Anything that evaluates to a number, but is not in itself a number.
valueReference: ID | Number;

ID: [a-zA-Z]+[0-9a-zA-Z]*;
Type: 'bool' | 'number' | 'int' | 'point'; //If named 'bool' it gives clash with bool declaration
Number: Integer|Float;
fragment Integer: [0-9]+ | '-'[0-9]+;
fragment Float : [0-9]+'.'[0-9]+ | '-'[0-9]+ | '-'[0-9]+'.'[0-9]+;
Boolean: 'false' | 'true';
Terminator: ';';

WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines
COMMENT: '/*' .*? '*/' -> skip;
