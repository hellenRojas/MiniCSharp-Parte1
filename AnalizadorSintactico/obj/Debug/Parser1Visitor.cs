//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\usuario\Desktop\MiniCSharp-Parte1\AnalizadorSintactico\Parser1.g4 by ANTLR 4.5-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AnalizadorSintactico {

using System;

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="Parser1"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface IParser1Visitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] Parser1.ProgramContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.constantDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantDecl([NotNull] Parser1.ConstantDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.varDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDecl([NotNull] Parser1.VarDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.classDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassDecl([NotNull] Parser1.ClassDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.methodDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodDecl([NotNull] Parser1.MethodDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.formPars"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormPars([NotNull] Parser1.FormParsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] Parser1.TypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] Parser1.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] Parser1.BlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.actPars"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitActPars([NotNull] Parser1.ActParsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondition([NotNull] Parser1.ConditionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.condTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondTerm([NotNull] Parser1.CondTermContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.condFact"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondFact([NotNull] Parser1.CondFactContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] Parser1.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTerm([NotNull] Parser1.TermContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactor([NotNull] Parser1.FactorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.designator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDesignator([NotNull] Parser1.DesignatorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelop([NotNull] Parser1.RelopContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.addop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddop([NotNull] Parser1.AddopContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.mulop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMulop([NotNull] Parser1.MulopContext context);
}
} // namespace AnalizadorSintactico
