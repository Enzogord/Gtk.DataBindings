﻿using System;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Bindings.Utilities
{
	/// <summary>
	/// Copy utilitis from QSProjects for works with properties.
	/// </summary>
	public static class PropertyUtil
	{
		public static string GetPropertyName<TObject> (this TObject type,
			Expression<Func<TObject, object>> propertyRefExpr)
		{
			return GetPropertyNameCore (propertyRefExpr.Body);
		}

		public static string GetName<TObject> (Expression<Func<TObject, object>> propertyRefExpr)
		{
			return GetPropertyNameCore (propertyRefExpr.Body);
		}

		internal static string GetPropertyNameCore (Expression propertyRefExpr)
		{
			if (propertyRefExpr == null)
				throw new ArgumentNullException ("propertyRefExpr", "propertyRefExpr is null.");

			MemberExpression memberExpr = propertyRefExpr as MemberExpression;
			if (memberExpr == null) {
				UnaryExpression unaryExpr = propertyRefExpr as UnaryExpression;
				if (unaryExpr != null && unaryExpr.NodeType == ExpressionType.Convert)
					memberExpr = unaryExpr.Operand as MemberExpression;
			}

			if (memberExpr != null && memberExpr.Member.MemberType == MemberTypes.Property)
				return memberExpr.Member.Name;

			throw new ArgumentException ("No property reference expression was found.",
				"propertyRefExpr");
		}
	}
}

