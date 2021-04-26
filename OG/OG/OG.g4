grammar OG;


program: settings=machineSettings drawFunction=draw functionsDeclarations=functionDcls shapeDeclarations=shapeDcls EOF #prog
       ;

// Machine Settings
machineSettings  : 'Machine' machineModifications=machineMods ';' 
             |                                                
             ;

machineMods : '.' workAreaModifications=workAreaMod machineModifications=machineMods   
            |                                                                          
            ;

workAreaMod : 'WorkArea' workAreaModificationProperties=workAreaModPrpts //#workAreaModifier
            ;
                 
workAreaModPrpts : '.' sizeProperty=sizePrpt workAreaModificationProperties=workAreaModPrpts //#workAreaModifierProperties
                 |                                                                           //#endOfWorkAreaModifierProperties
                 ;
                           
sizePrpt : 'size' '(' workAreaVariables=workAreaVars ')' //#sizeProperty
         ;

workAreaVars : 'xmin' '=' xmin=mathExpression ',' 'xmax' '=' xmax=mathExpression ',' 'ymin' '=' ymin=mathExpression',' 'ymax' '=' ymax=mathExpression;

// Shape Declarations and Function Declarations (Could maybe be moved down in their respective region?)
shapeDcls   : currentShapeDcl=shapeDcl shapeDeclarations=shapeDcls
            |
            ;
            
functionDcls: functionDcl functionDcls
            |
            ;

// Draw
draw             : 'draw' '{' shapesToDraw=drawCommands '}';

drawCommands: drawCommand drawCommands                
            |
            ;
            
drawCommand     : id=ID';'                             #drawCmd
                | id=ID fromCmd=fromCommand ';'        #drawFromCmd
                ;
//Shapes:
shapeDcl            : 'shape' id=ID '{' bdy=body '}'
                    ;


body: statements=stmts;

stmts: currentStatement = stmt statements =stmts | ;
stmt:  dcl  =declaration 
    | assign=assignment
    | cmd   =command;             

                    
assignments : assign=assignment assignmnts = assignments    #assgnments
            |                                               #noAssignmentsDefined
            ;
declarations: dcl=declaration dcls=declarations  #dcls
            |                                    #noDeclarationsDefined
            ;
            
commands: cmd=command cmds=commands              #cmds
        |                                        #noCmdsDeclared
        ;

declaration         : numberDcl=numberDeclaration';' #numberDcl
                    | pointDcl=pointDeclaration';'   #pointDcl
                    | boolDcl=booleanDeclaration';'  #boolDcl
                    ;
booleanDeclaration  : 'bool'   id=ID   '=' value=boolExpression
                    ;
numberDeclaration   : 'number' id=ID '=' value=mathExpression
                    ;
                    
pointDeclaration    : 'point'  id=ID '='  value=pointReference    #pointDclPointRefAssign
                    | 'point'  id=ID  '=' value=ID                #pointDclIdAssign
                    ;

pointReference      :  '(' tuple=numberTuple ')' 
                    | startPoint=startPointReference
                    | endPoint=endPointReference 
                    | idPoint=ID
                    | funcCall=functionCall
                    ;
                    
numberTuple         : lhs=mathExpression ',' rhs=mathExpression;

assignment          : variableAssignment 
                    | propertyAssignment
                    ;
propertyAssignment  : xyVal=coordinateXYValue '=' value=mathExpression';'
                    ;


variableAssignment  : id=ID'=' value=ID             ';' #idAssign
                    | id=ID '=' funcCall=functionCall ';' #functionCallAssign
                    | id=ID'=' value=boolExpression ';' #boolAssign    
                    | id=ID'=' value=mathExpression ';' #numberAssign
                    | pointAssignment               ';' #pointAssign
                    
                    ; 

pointAssignment     :  endPointAssignment
                    |  startPointAssignment     
                    |  id=ID '=' value=pointReference
                    ;

startPointAssignment: id=startPointReference '=' value=pointReference
                    ;
endPointAssignment  : id=endPointReference '=' value=pointReference
                    ;


//Generel expressions:
expression      : id=ID 
                | functionCall
                | mathExpression 
                | boolExpression 
                ;    
                     //term   ((Plus_Minus) term)*
mathExpression  : lhs=term op=Plus_Minus rhs=mathExpression        #infixAdditionExpr //operand står i midten
                | child=term                                       #singleTermExpr
                ;
                
term            : lhs=factor op=Mul_Div rhs=term                   #infixMultExpr              
                | child=factor                                     #singleTermChild //Child er et vidtdækkende begreb
                ;      
factor          : lhs=atom pow='^' rhs=factor                      #powerExpr
                | child=atom                                       #singleAtom   
                |'(' mathExpr=mathExpression ')'                   #parenthesisMathExpr
                ;

atom            : funcCall=functionCall                         #atomfuncCall
                | value=Number                                  #number
                | xyValue=coordinateXYValue                     #atomXYValue
                | id=ID                                         #atomId
                ;
               

boolExpression  : id=ID                                                 #boolExprID
                | value=BooleanValue                                    #boolExprTrueFalse
                | funcCall=functionCall                                 #boolExprFuncCall
                | lhs=mathExpression BoolOperator rhs=mathExpression    #boolExprMathComp
                | lhs=boolExpression LogicOperator rhs=boolExpression   #boolExprBoolComp
                | '!'boolExpr=boolExpression                            #boolExprNotPrefix
                | '('boolExpression')'                                  #parenthesisBoolExpr
                ;



//Commands:
//Movement commands:
command         : iterCmd=iterationCommand
                | movementCmd=movementCommand
                | drawCmd=drawCommand
                ;

movementCommand : lineCmd=lineCommand ';' 
                | curveCmd=curveCommand';'
                ;
                

lineCommand     : type='line' fromCmd=fromCommand  toCmds=toCommands;

toCommands: toCmd=toCommand chainedToCmds=toCommands         
          | toCmd=toCommand                                
          ;

   

curveCommand    : type='curve''.'modifier='withAngle' '('angle=mathExpression ')'  fromCmd=fromCommand toCmds=toCommands;
                

toCommand       : '.''to''(' id=ID ')'                      #toWithId
                | '.''to''(' tuple=numberTuple ')'          #toWithNumberTuple
                | '.''to''(' toPoint=startPointReference ')'  #toWithStartPointRef
                | '.''to''(' toPoint=endPointReference ')'    #toWithEndPointRef
                ;

fromCommand     :  '.''from' '(' id=ID')'                             #fromWithId
                |  '.''from' '(' tuple=numberTuple ')'                #fromWithNumberTuple
                |  '.''from' '(' fromPoint=startPointReference ')'    #fromWithStartPointRef
                |  '.''from' '(' fromPoint=endPointReference ')'      #fromWithEndPointRef
                ;


//Iterative statements:
iterationCommand: numberIterCmd=numberIteration 
                | untilIterCmd=untilIteration
                ;
numberIteration : 'repeat''('iterator=mathExpression')' statements=body 'repeat.end'
                ;

untilIteration  : 'repeat''.''until''(' iterator=functionCall')' statements=body 'repeat.end'    #untilFuncCall //Function call er allerede indeholdt i boolExpression.
                | 'repeat''.''until''(' iterator=boolExpression')' statements=body 'repeat.end'  #untilCondition  
                ;

//Functions: 
functionDcl             : returnFunctionDCL 
                        | voidFunctionDCL
                        ;
                        
returnFunctionDCL       : 'function' type=typeWord funcName=ID '('paramDcls=parameterDeclarations ')''{' statements=body returnStmt=returnStatement '}';

typeWord                : PointDCLWord 
                        | BoolDCLWord 
                        | NumberDCLWord
                        ;

voidFunctionDCL         : 'function' type='void' id=ID '(' paramDcls=parameterDeclarations ')'  '{' statements=body '}'; //Måske skal den her slettes Hvad kan den bruges til som shapes ikke alerede kan

parameterDeclarations   :  currentParamDcl=parameterDcl ',' paramDcls=parameterDeclarations #multiParamDcl
                        |  paramDcl=parameterDcl                                 #singleParamDcl
                        |                                                        #noParamsDcl
                        ;
parameterDcl: type=typeWord id=ID;      
                  
functionCall            : id=ID '(' params=passedParams ')' 
                        ; 




passedParams: firstParameter=passedParam ',' params=passedParams #multiParameters  //Kig på side 257 og overvej en multi params production
            | parameter=passedParam                              #singleParameter   //angiver at dette er den sidste parameter i en hvilkensomhelst funktion med parametre
            |                                                    #noParameter   //samme som ovenfor men efter sidste parameter()
            ;

passedParam : id = ID                                       #passedID
            | funcCall = functionCall                       #passedFunctionCall
            | expr = expression                             #passedDirectValue
            | endpointRef =  endPointReference              #passedEndPointReference
            | startpointRef = startPointReference           #passedStartPointReference
            ;



returnStatement         : 'return' id=ID ';'         #returnValueReference
                        | 'return' expr=expression ';' #returnDirectValue
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

startPointReference : id=ID'.''startPoint';
endPointReference   : id=ID'.''endPoint';
If  : 'if';
Then: 'then';

coordinateXYValue: (id=ID xy='.x') | (id=ID xy='.y') | (startPoint=startPointReference|endPoint=endPointReference) (xy='.x'|xy='.y') ;
ID: [a-zA-Z]+[0-9a-zA-Z]*; //ID skal være nederst for ikke at overwrite alle de andre keywords.



