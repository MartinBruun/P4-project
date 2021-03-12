
grammar OG;
program: machine draw functionDeclaration* shapeDefinition*;
machine: 'Machine''.''WorkArea''.''size' '(' machineVariables ')'';';
machineVariables : number ',' number ',' number',' number;
draw: 'draw' '{' (ID';')* '}';

//Shapes:
shapeDefinition: 'shape' ID '{' body '}';
body: declaration* command* expression;

//Generel expressions:
expression: (mathExpression* | booleanExpression*);
booleanExpression: mathExpression Comparer mathExpression | booleanExpression Comparer booleanExpression | Boolean;
mathExpression: (valueReference Operator valueReference (Operator valueReference)*);
valueReference: ID | number | Integer;

//Basic declarations:
declaration: (numberDeclaration | pointDeclaration | booleanDeclaration)';';
numberDeclaration: 'number' ID '=' mathExpression | valueReference;
pointDeclaration:  'point'  ID '=' ( coordinateReference | ID );
booleanDeclaration:  'bool'   ID '=' booleanExpression;
coordinateReference:  '(' numberTuple ')';
numberTuple: (mathExpression | number) ',' (mathExpression | number);


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
functionDeclaration: returnFunction | voidFunction;
returnFunction: 'function' Type ID parameterDeclerationList '{' body returnStatement '}';
voidFunction: 'function' 'void' ID parameterDeclerationList '{' body '}';
parameterDeclerationList: '('parameters')';
parameters: Type ID | (Type ID',')+ Type ID  | ;
parameterList: (ID | expression);
functionCall: ID '(' parameterList ')'';';
returnStatement: 'return' (expression | valueReference) ';';


//Tokens and help types:
number: Integer | Float;
Type: 'bool' | 'number' | 'int' | 'point'; //If named 'bool' it gives clash with bool declaration
Comparer: '<' |'>'|'=='|'!='|'>='|'<='|'||'|'&&';
Operator: '+'|'-'|'*'|'/';
Integer: [0-9]+ | '-'[0-9]+;
Boolean: 'false' | 'true';
ID: [a-zA-Z]+[0-9a-zA-Z]*;
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines
Float : [0-9]+ | [0-9]+'.'[0-9]+ | '-'[0-9]+ | '-'[0-9]+'.'[0-9]+;
COMMENT: '/*' .*? '*/' -> skip;
NumberDeclarationWord: 'number';
BoolDeclarationWord: 'bool';
PointDeclarationWord: 'point';