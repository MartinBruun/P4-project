
grammar mainGrammar;
program: shapes draw;


//Shapes
shapes: shape shapes | ;
shape: 'shape' ID '{' shapeBody '}';
shapeBody: declarations motions ;

motions: motion motions | ;
motion: line StatementTerminator | curve;

curve: 'curve' fromCommand toCommand 'with radius' Number clockwiseOrNot;
clockwiseOrNot: 'counterclockwise' | ;

line: 'line' initiateMotions;

initiateMotions: fromCommand toCommand toCommands;

fromCommand: '.from' pointReference;

pointReference: '('Number','Number')' | '('ID')';

declarations: pointDeclarations declarations | numberDeclaration declarations;

pointDeclarations: 'point ' ID '=' pointReference StatementTerminator;
numberDeclaration: 'number' ID '=' Number StatementTerminator;


toCommands: toCommand toCommands;
toCommand: '.' 'to' pointReference;

draw: 'draw' '{' drawShapes '}';
drawShapes: drawShape drawShapes;
drawShape: ID StatementTerminator;


ID: ('a'..'z' | 'A'..'Z')('0'..'9' | 'a'..'z' | 'A'..'Z')*;
Number: ('0'..'9')+ | (('0'..'9')+'.'('0'..'9')*);

CHAR: 'a'..'z';

//Parserrules (terminals) are lowerletter: prule: ....

StatementTerminator: ';';