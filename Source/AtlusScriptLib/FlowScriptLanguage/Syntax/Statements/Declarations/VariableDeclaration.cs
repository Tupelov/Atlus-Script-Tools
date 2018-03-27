﻿using System.Text;
using AtlusScriptLib.Common.Libraries;
using AtlusScriptLib.FlowScriptLanguage.Decompiler;

namespace AtlusScriptLib.FlowScriptLanguage.Syntax
{
    public class VariableDeclaration : Declaration
    {
        public VariableModifier Modifier { get; set; }

        public TypeIdentifier Type { get; set; }

        public Expression Initializer { get; set; }

        public VariableDeclaration() : base( DeclarationType.Variable )
        {
            Modifier = new VariableModifier();
        }

        public VariableDeclaration( VariableModifier modifier, TypeIdentifier type, Identifier identifier, Expression initializer )
            : base( DeclarationType.Variable, identifier )
        {
            Modifier = modifier;
            Type = type;
            Initializer = initializer;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append( $"{Modifier} " );

            builder.Append( $"{Type} {Identifier}" );
            if ( Initializer != null )
            {
                builder.Append( $" = {Initializer}" );
            }

            return builder.ToString();
        }

        public static VariableDeclaration FromLibraryConstant( FlowScriptModuleConstant libraryConstant )
        {
            var modifier = new VariableModifier( VariableModifierKind.Constant );
            var type = new TypeIdentifier( KeywordDictionary.KeywordToValueType[ libraryConstant.Type ] );
            var identifier = new Identifier( type.ValueKind, libraryConstant.Name );
            var initializer = Expression.FromText( libraryConstant.Value );

            return new VariableDeclaration( modifier, type, identifier, initializer );
        }
    }
}
