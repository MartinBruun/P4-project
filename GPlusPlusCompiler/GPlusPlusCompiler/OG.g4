
grammar OG;
program: machine draw functionDeclaration* shapeDefinition*;
machine: 'Machine' '.WorkArea''.size' '(' machineVariables ')'';';
machineVariables : number ',' number ',' number',' number;
draw: 'draw' '{' (ID';')* '}';

//Shapes:
shapeDefinition: 'shape' ID '{' body '}';
body: declaration* command* expression;

//Basic declarations and assignments:
declaration: (numberDeclaration | pointDeclaration | booleanDeclaration)';';
numberDeclaration: 'number' ID '=' mathExpression | valueReference;
pointDeclaration:  'point'  ID '=' ( coordinateReference | ID );
booleanDeclaration:  'bool'   ID '=' booleanExpression;
coordinateReference:  '(' numberTuple ')';
numberTuple: (mathExpression | numberRefence) ',' (mathExpression | numberRefence);
assignment: ID '=' (expression | ID);

//Generel expressions:
expression: (mathExpression* | booleanExpression*);
booleanExpression: mathExpression Comparer mathExpression | booleanExpression Comparer booleanExpression | Boolean;

mathExpression: mathExpression AdditionTerm term | term;
term: term MultiplicationTerm factor | factor;
factor: '(' mathExpression ')' | valueReference;


//Commands:
//Movement commands:
command: iterationCommand | movementCommand | functionCall;
movementCommand: (lineCommand | curveCommand)';';
lineCommand: 'line''.from' '(' (numberTuple | ID)')' toCommand+;
toCommand : '.to''(' (numberTuple | ID) ')';
curveCommand: 'curve' '.withAngle''(' number ')' '.from''('(numberTuple | ID)')' toCommand;

//Iteration commands:
iterationCommand: numberIteration | untilIteration;
numberIteration: 'repeat''('Integer')' body 'repeat''.end';
untilIteration: 'repeat''.until''('booleanExpression')' body 'repeat''.end';


//Functions: 
functionDeclaration: returnFunctionDCL | voidFunctionDCL;
returnFunctionDCL: 'function' Type ID parameterDeclerations '{' body returnStatement '}';
voidFunctionDCL: 'function' 'void' ID parameterDeclerations '{' body '}';
parameterDeclerations: '('parameters')';
parameters: Type ID | (Type ID',')+ Type ID  | ;
parameterList: (ID | expression);
functionCall: ID '(' parameterList ')'';';
returnStatement: 'return' (expression | valueReference) ';';

//Mathematics:
mathFunction: squareRoot;
squareRoot: ('sqrt(' mathExpression | ID)')';


//Tokens and help variables:
numberRefence: number | coordinatePropertyValue; //Anything that evaluates to a number, but is not in itself a number.
number: Integer | Float;
coordinatePropertyValue: ID'.x' | ID'.y';
operator: MultiplicationTerm | AdditionTerm;
valueReference: ID | number | mathFunction;

MultiplicationTerm: '/'|'*';
AdditionTerm: '+' | '-';
Type: 'bool' | 'number' | 'int' | 'point'; //If named 'bool' it gives clash with bool declaration
Comparer: '<' |'>'|'=='|'!='|'>='|'<='|'||'|'&&';
Integer: [0-9]+ | '-'[0-9]+;
Boolean: 'false' | 'true';
ID: [a-zA-Z]+[0-9a-zA-Z]*;
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines
Float : [0-9]+'.'[0-9]+ | '-'[0-9]+ | '-'[0-9]+'.'[0-9]+;
COMMENT: '/*' .*? '*/' -> skip;
NumberDeclarationWord: 'number';
BoolDeclarationWord: 'bool';
PointDeclarationWord: 'point';
Terminator: ';';