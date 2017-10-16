//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from d:\users\smart\documents\visual studio 2017\Projects\AtlusScriptToolchain\Source\AtlusScriptLib\FlowScriptLanguage\Compiler\Parser\Grammar\FlowScript.g4 by ANTLR 4.6.4

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AtlusScriptLib.FlowScriptLanguage.Compiler.Parser.Grammar {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IFlowScriptListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.4")]
[System.CLSCompliant(false)]
public partial class FlowScriptBaseListener : IFlowScriptListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>logicalOrExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalOrExpression([NotNull] FlowScriptParser.LogicalOrExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>logicalOrExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalOrExpression([NotNull] FlowScriptParser.LogicalOrExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>equalityExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEqualityExpression([NotNull] FlowScriptParser.EqualityExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>equalityExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEqualityExpression([NotNull] FlowScriptParser.EqualityExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>assignmentExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentExpression([NotNull] FlowScriptParser.AssignmentExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>assignmentExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentExpression([NotNull] FlowScriptParser.AssignmentExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>castExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCastExpression([NotNull] FlowScriptParser.CastExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>castExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCastExpression([NotNull] FlowScriptParser.CastExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>relationalExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelationalExpression([NotNull] FlowScriptParser.RelationalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>relationalExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelationalExpression([NotNull] FlowScriptParser.RelationalExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>additionExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditionExpression([NotNull] FlowScriptParser.AdditionExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>additionExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditionExpression([NotNull] FlowScriptParser.AdditionExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>compoundExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompoundExpression([NotNull] FlowScriptParser.CompoundExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>compoundExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompoundExpression([NotNull] FlowScriptParser.CompoundExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>nullExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNullExpression([NotNull] FlowScriptParser.NullExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>nullExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNullExpression([NotNull] FlowScriptParser.NullExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>unaryPrefixExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryPrefixExpression([NotNull] FlowScriptParser.UnaryPrefixExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>unaryPrefixExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryPrefixExpression([NotNull] FlowScriptParser.UnaryPrefixExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>logicalAndExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalAndExpression([NotNull] FlowScriptParser.LogicalAndExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>logicalAndExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalAndExpression([NotNull] FlowScriptParser.LogicalAndExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicationExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicationExpression([NotNull] FlowScriptParser.MultiplicationExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicationExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicationExpression([NotNull] FlowScriptParser.MultiplicationExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>callExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCallExpression([NotNull] FlowScriptParser.CallExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>callExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCallExpression([NotNull] FlowScriptParser.CallExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>primaryExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryExpression([NotNull] FlowScriptParser.PrimaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>primaryExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryExpression([NotNull] FlowScriptParser.PrimaryExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>unaryPostfixExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryPostfixExpression([NotNull] FlowScriptParser.UnaryPostfixExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>unaryPostfixExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryPostfixExpression([NotNull] FlowScriptParser.UnaryPostfixExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierExpression([NotNull] FlowScriptParser.IdentifierExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierExpression([NotNull] FlowScriptParser.IdentifierExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantExpression([NotNull] FlowScriptParser.ConstantExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="FlowScriptParser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantExpression([NotNull] FlowScriptParser.ConstantExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.compilationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompilationUnit([NotNull] FlowScriptParser.CompilationUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.compilationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompilationUnit([NotNull] FlowScriptParser.CompilationUnitContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.importStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImportStatement([NotNull] FlowScriptParser.ImportStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.importStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImportStatement([NotNull] FlowScriptParser.ImportStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] FlowScriptParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] FlowScriptParser.StatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.compoundStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompoundStatement([NotNull] FlowScriptParser.CompoundStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.compoundStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompoundStatement([NotNull] FlowScriptParser.CompoundStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.declarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarationStatement([NotNull] FlowScriptParser.DeclarationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.declarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarationStatement([NotNull] FlowScriptParser.DeclarationStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.functionDeclarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclarationStatement([NotNull] FlowScriptParser.FunctionDeclarationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.functionDeclarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclarationStatement([NotNull] FlowScriptParser.FunctionDeclarationStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.procedureDeclarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedureDeclarationStatement([NotNull] FlowScriptParser.ProcedureDeclarationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.procedureDeclarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedureDeclarationStatement([NotNull] FlowScriptParser.ProcedureDeclarationStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.variableDeclarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclarationStatement([NotNull] FlowScriptParser.VariableDeclarationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.variableDeclarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclarationStatement([NotNull] FlowScriptParser.VariableDeclarationStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.labelDeclarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabelDeclarationStatement([NotNull] FlowScriptParser.LabelDeclarationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.labelDeclarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabelDeclarationStatement([NotNull] FlowScriptParser.LabelDeclarationStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.parameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterList([NotNull] FlowScriptParser.ParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.parameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterList([NotNull] FlowScriptParser.ParameterListContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter([NotNull] FlowScriptParser.ParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter([NotNull] FlowScriptParser.ParameterContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.expressionList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionList([NotNull] FlowScriptParser.ExpressionListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.expressionList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionList([NotNull] FlowScriptParser.ExpressionListContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] FlowScriptParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] FlowScriptParser.ExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimary([NotNull] FlowScriptParser.PrimaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimary([NotNull] FlowScriptParser.PrimaryContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant([NotNull] FlowScriptParser.ConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant([NotNull] FlowScriptParser.ConstantContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStatement([NotNull] FlowScriptParser.IfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStatement([NotNull] FlowScriptParser.IfStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStatement([NotNull] FlowScriptParser.ForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStatement([NotNull] FlowScriptParser.ForStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatement([NotNull] FlowScriptParser.WhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatement([NotNull] FlowScriptParser.WhileStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.breakStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBreakStatement([NotNull] FlowScriptParser.BreakStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.breakStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBreakStatement([NotNull] FlowScriptParser.BreakStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.continueStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContinueStatement([NotNull] FlowScriptParser.ContinueStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.continueStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContinueStatement([NotNull] FlowScriptParser.ContinueStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] FlowScriptParser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] FlowScriptParser.ReturnStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="FlowScriptParser.gotoStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGotoStatement([NotNull] FlowScriptParser.GotoStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FlowScriptParser.gotoStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGotoStatement([NotNull] FlowScriptParser.GotoStatementContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace AtlusScriptLib.FlowScriptLanguage.Compiler.Parser.Grammar
