
grammar OG;

program: machine draw functionDeclaration* shapeDefinition*;
machineVariables : 'xmin' '=' mathExpression ',' 'xmax' '=' mathExpression ',' 'ymin' '=' mathExpression',' 'ymax' '=' mathExpression;
machine          : 'Machine' '.''WorkArea''.''size' '(' machineVariables ')'';';
draw             : 'draw' '{' drawCommand* '}';

//Shapes:
shapeDefinition     : 'shape' ID '{' body '}';
body                :  (expression | declaration |  assignment | command)+ |  ; //Fix

declaration         : (numberDeclaration | pointDeclaration | booleanDeclaration)';' ;
booleanDeclaration  : 'bool' ID   '=' boolExpression;
numberDeclaration   : 'number' ID '=' mathExpression;
pointDeclaration    : 'point'  ID '=' ( pointReference | ID );
pointReference : '(' numberTuple ')' | StartPointReference | EndPointReference | functionCall;
numberTuple         : mathExpression ',' mathExpression;

//Basic declarations and assignments:
assignment          : variableAssignment | propertyAssignment;
propertyAssignment  : CoordinateXYValue '=' mathExpression';';

variableAssignment  : (idAssign | boolAssignment | numberAssignment | pointAssignment) ';';  //Problematisk med ID = ID, da alt bliver til bool assign. Skal man lave overordnet assign med ID som besluttes semantisk?.
idAssign            :   ID'='ID;
boolAssignment      :   ID'=' boolExpression;
numberAssignment    :   ID'=' mathExpression; 
pointAssignment     :  endPointAssignment | startPointAssignment | (ID'=' pointReference | ID);

startPointAssignment: StartPointReference '=' pointReference;
endPointAssignment  : EndPointReference '=' pointReference;


//Generel expressions:
expression      : (ID | mathExpression | boolExpression | functionCall);

mathExpression  : term   ((Plus_Minus) term)*;
term            : factor ((Mul_Div) factor)*;
factor          : atom ('^' atom)*;
atom            : functionCall | Number | CoordinateXYValue | ID | '(' mathExpression ')'  ; //Atom is a sub-equation
//signedAtom : PLUS signedAtom | MINUS signedAtom | atom   ;

boolExpression  : ID |  BooleanValue |  functionCall 
                | mathExpression BoolOperator mathExpression 
                | boolExpression LogicOperator boolExpression 
                | '!'boolExpression;  //Overvej function call

//a == true er ikke gyldigt!


//Commands:
//Movement commands:
command         : iterationCommand | movementCommand | drawCommand;

movementCommand : (lineCommand | curveCommand)';';
lineCommand     : 'line' '.' 'from' '(' (numberTuple | ID | pointReference)')' toCommand+;
curveCommand    : 'curve' '.' 'withAngle' '(' mathExpression ')' '.' 'from' '('(numberTuple | ID)')' toCommand;
toCommand       : '.to''(' (numberTuple | ID) ')';
drawCommand     : ID';';



//Iterative statements:
iterationCommand: numberIteration | untilIteration;
numberIteration : 'repeat''('mathExpression')' body 'repeat.end'; //Ret krop?
untilIteration  : 'repeat''.''until''('(boolExpression | functionCall)')' body 'repeat.end';


//Functions: 
functionDeclaration     : returnFunctionDCL | voidFunctionDCL;
returnFunctionDCL       : 'function' typeWord ID parameterDeclarations '{' body returnStatement '}';
typeWord                : (PointDCLWord | BoolDCLWord | NumberDCLWord);
voidFunctionDCL         : 'function' 'void' ID parameterDeclarations '{' body '}';

parameterDeclarations   : '('parameters')';
parameters              :  (typeWord ID',')* typeWord ID | ;
functionCall            : ID '(' parameterList ')';
parameterList           : ( (ID | expression | CoordinateXYValue)',')* (ID | expression | CoordinateXYValue) | ;
returnStatement         : 'return' (ID | expression) ';';



Number: Integer|Float;

//Tokens and help variables:
BooleanValue    : 'true'| 'false';
fragment Integer: [0-9]+ | '-'[0-9]+;
fragment Float  : [0-9]+'.'[0-9]+ | '-'[0-9]+ | '-'[0-9]+'.'[0-9]+;

WS     : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines
COMMENT: '/*' .*? '*/' -> skip;

//Startwords
ShapeDCLWord : 'shape';
PointDCLWord : 'point';
BoolDCLWord  : 'bool';
NumberDCLWord:'number';
DrawDCLWord  :  'draw';


//CommandWords: 
WithAngle    : 'withAngle';
Curve        : 'curve';
Line         : 'line';
To           : 'to';
From         : 'from';
RepeatStart  : 'repeat';
RepeatEnd    : 'repeat.end';
Until        : 'until';
DOT          : '.';

//Function specific words
FunctionStartWord : 'function';
FunctionReturnWord: 'return';
Void              : 'void';

//Operators for mathematics and expressions
LParen   : '('   ;
RParen   : ')'   ;

Plus_Minus: Plus | Minus;
Plus     : '+'   ;
Minus    : '-'   ;

Mul_Div  : Times | Div;
Times    : '*'   ;
Div      : '/'   ;

Pow      : '^'   ;

LogicOperator    :  AND | OR;
BoolOperator     :  LT  | GT | EQ;
fragment GT       : '>'   ;
fragment LT       : '<'   ;
fragment EQ       : '=='  ;
fragment AND      : '&&'  ;
NOT               : '!'   ;
fragment OR       : '||'  ;

Assign   : '=';

//Scopes and terminators;
OpenScope   :  '{';
CloseScope  : '}';
Terminator  : ';';
Seperator   : ',';

XMIN: 'xmin';
XMAX: 'xmax';
YMAX: 'ymin';
YMIN: 'ymax';

// 'Machine' '.''WorkArea''.''size' '(' machineVariables ')'';'
Machine : 'Machine'; 
WorkArea: 'WorkArea';
Size    : 'size';

StartPointReference : ID'.''startPoint';
EndPointReference   : ID'.''endPoint';
If  : 'if';
Then: 'then';

CoordinateXYValue: (ID'.x') | (ID'.y') | (StartPointReference|EndPointReference) ('.x'|'.y') ;
ID: [a-zA-Z]+[0-9a-zA-Z]*; //ID skal være nederst for ikke at overwrite alle de andre keywords.



