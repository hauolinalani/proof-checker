# Proofity
Proofity uses maximal munch to scan input tokens in predicate logic, and then uses a modified version of the shunting yard algorithm to generate a parse tree. Then, rules are checked to ensure correct usage. A symbol table is created to track variables and check for scoped rules, such as implications and forall statements.
