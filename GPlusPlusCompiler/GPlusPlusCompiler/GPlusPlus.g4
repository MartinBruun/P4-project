
grammar GPlusPlus;
r  : 'hello' ID p;         // match keyword hello followed by an identifier
p  : 'HELLO';
ID : [a-z]+ ;             // match lower-case identifiers
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines

