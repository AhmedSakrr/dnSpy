﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media.TextFormatting;
using dnSpy.Contracts.Text.Editor;

namespace dnSpy.Contracts.Text.Formatting {
	/// <summary>
	/// WPF <see cref="ITextView"/> line
	/// </summary>
	public interface IWpfTextViewLine : ITextViewLine {
		/// <summary>
		/// Gets a list of text lines that make up the formatted text line
		/// </summary>
		ReadOnlyCollection<TextLine> TextLines { get; }

		/// <summary>
		/// Gets the visible area in which this text line will be rendered
		/// </summary>
		Rect VisibleArea { get; }

		/// <summary>
		/// Gets the formatting for a particular character in the line
		/// </summary>
		/// <param name="bufferPosition">The buffer position of the desired character</param>
		/// <returns></returns>
		TextRunProperties GetCharacterFormatting(SnapshotPoint bufferPosition);
	}
}
