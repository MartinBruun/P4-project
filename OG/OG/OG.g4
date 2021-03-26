grammar OG;

program: tool=machine main=draw functions=functionDcls? shapes=shapeDcls #prog
       ;
       
shapeDcls   : lhc=shapeDcl rhc=shapeDcls #shapeDclsChildren
            |                            #shapeDclEmpty
            ;
            
functionDcls: functionDcl functionDcls   #functionCallChildren
            |                            #functionCallEmpty
            ;
       

machineVariables : 'xmin' '=' xmin=mathExpression ',' 'xmax' '=' xmax=mathExpression ',' 'ymin' '=' ymin=mathExpression',' 'ymax' '=' ymax=mathExpression;
machine          : 'Machine' '.''WorkArea''.''size' '(' machineVariables ')'';';
draw             : 'draw' '{' drawCommands '}';

drawCommands: drawCommand drawCommands #drawCommandsChildren
            |                          #drawCommandsEmpty
            ;

//Shapes:
shapeDcl            : 'shape' ID '{' bdy=body '}'
                    ;


body                :  (declaration |  assignment | command)+ 
                    |  
                    ;
                    
assignments : assignment assignments    #assignmentsChildren
            |                           #assignmentsEmpty
            ;
declarations: declaration declarations  #declarationsChildren
            |                           #declarationsEmpty
            ;
commands: command commands              #commandsChildren
        |                               #commandsEmpty
        ;

declaration         : numberDcl=numberDeclaration';' #numberDcl
                    | pointDcl=pointDeclaration';'   #pointDcl
                    | boolDcl=booleanDeclaration';'  #boolDcl
                    ;
booleanDeclaration  : 'bool' lhs=ID   '=' rhs=boolExpression
                    ;
numberDeclaration   : 'number' lhs=ID '=' rhs=mathExpression
                    ;
pointDeclaration    : 'point'  lhs=ID '=' rhs=pointReference    #pointDclPointRefAssign
                    | 'point'  lhs=ID  '='rhs=ID                #pointDclIdAssign
                    ;

pointReference      :  '(' tuple=numberTuple ')' 
                    | StartPointReference
                    | EndPointReference 
                    | ID
                    | functionCall
                    ;
numberTuple         : lhs=mathExpression ',' rhs=mathExpression;

//Basic declarations and assignments:
assignment          : variableAssignment 
                    | propertyAssignment
                    ;
propertyAssignment  : CoordinateXYValue '=' mathExpression';'
                    ;

variableAssignment  : lhs=ID'=' rhs=ID             ';' #idAssign
                    | lhs=ID'=' rhs=boolExpression ';' #boolAssign    
                    | lhs=ID'=' rhs=mathExpression ';' #numberAssign
                    | pointAssignment              ';' #pointAssign
                    ; 

pointAssignment     :  endPointAssignment  //Bemærk navn på pointAssign! De er ikke ens!
                    |  startPointAssignment 
                    |  lhs=ID '=' rhs=pointReference
                    ;

startPointAssignment: lhs=StartPointReference '=' rhs=pointReference
                    ;
endPointAssignment  : lhs=EndPointReference '=' rhs=pointReference
                    ;


//Generel expressions:
expression      : ID 
                | mathExpression 
                | boolExpression 
                | functionCall
                ;    
                     //term   ((Plus_Minus) term)*
mathExpression  : lhs=term op=Plus_Minus rhs=mathExpression        #infixAdditionExpr //operand står i midten
                | child=term                                       #singleTermExpr
                ;
                
term            : lhs=factor op=Mul_Div rhs=term                   #infixMultExpr              
                | child=factor                                     #singleTermChild //Child er et vidtdækkende begreb
                ;      
factor          : lhs=atom pow='^' rhs=factor                      
                | child=atom                                          
                |'(' mathExpr=mathExpression ')'
                ;

atom            : funcCall=functionCall
                | value=Number 
                | coordinateValue=CoordinateXYValue 
                | idReference=ID
                ;
                
//signedAtom : PLUS signedAtom | MINUS signedAtom | atom   ;

boolExpression  : ID                                                    #boolExprID
                | BooleanValue                                          #boolExprTrueFalse
                | functionCall                                          #boolExprFuncCall
                | lhs=mathExpression BoolOperator rhs=mathExpression    #boolExprMathComp
                | lhs=boolExpression LogicOperator rhs=boolExpression   #boolExprBoolComp
                | '!'boolExpression                                     #boolExprNotPrefix   
                ;

//a == true er ikke gyldigt!


//Commands:
//Movement commands:
command         : iterationCommand
                | movementCommand
                | drawCommand
                ;

movementCommand : lineCommand ';' 
                | curveCommand';'
                ;
                
lineCommand     : 'line' '.' 'from' '(' (numberTuple | ID | pointReference)')' toCommand+







                ; //Udvid til flere regler?
curveCommand    : 'curve' '.' 'withAngle' '(' mathExpression ')' '.' 'from' '('(numberTuple | ID)')' toCommand
                ;
toCommand       : '.to''(' (numberTuple | pointReference) ')'
                
                ;
drawCommand     : ID';' 
                | ID '.'fromCommand ';'
                ;
fromCommand     :  'from' ( '('ID')' |  '(' numberTuple ')' | '(' StartPointReference ')' | '(' EndPointReference ')'| functionCall )
                ; //Udvid til flere regler?



//Iterative statements:
iterationCommand: numberIteration 
                | untilIteration
                ;
numberIteration : 'repeat''('mathExpression')' body 'repeat.end'
                ;
untilIteration  : 'repeat''.''until''('(boolExpression | functionCall)')' body 'repeat.end'
                ; //Udvid til flere regler?


//Functions: 
functionDcl             : returnFunctionDCL 
                        | voidFunctionDCL
                        ;
returnFunctionDCL       : 'function' typeWord ID parameterDeclarations '{' body returnStatement '}';
typeWord                : (PointDCLWord | BoolDCLWord | NumberDCLWord);
voidFunctionDCL         : 'function' 'void' ID parameterDeclarations '{' body '}';

parameterDeclarations   : '('parameters')';
parameters              :  (typeWord ID',')* typeWord ID 
                        | 
                        ;
functionCall            : ID '(' parameterList ')'
                        ;
parameterList           : ( (ID | expression | pointReference)',')* (ID | expression | pointReference) 
                        |
                        ; //Kan den simplificeres? Udvid til flere regler?
returnStatement         : 'return' (ID | expression) ';'
                        ;



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



