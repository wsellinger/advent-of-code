﻿namespace AdventOfCode.Year_2015
{
	/// <summary>
	/// --- Day 2: I Was Told There Would Be No Math ---
	/// 
	/// The elves are running low on wrapping paper, and so they need to submit an order for more. They have a list of the dimensions 
	/// (length l, width w, and height h) of each present, and only want to order exactly as much as they need.
	/// 
	/// Fortunately, every present is a box (a perfect right rectangular prism), which makes calculating the required wrapping paper for 
	/// each gift a little easier: find the surface area of the box, which is 2*l*w + 2*w*h + 2*h*l. The elves also need a little extra 
	/// paper for each present: the area of the smallest side.
	/// 
	/// For example:
	/// 
	///     A present with dimensions 2x3x4 requires 2*6 + 2*12 + 2*8 = 52 square feet of wrapping paper plus 6 square feet of slack, 
	///     for a total of 58 square feet.
	///     A present with dimensions 1x1x10 requires 2*1 + 2*10 + 2*10 = 42 square feet of wrapping paper plus 1 square foot of slack, 
	///     for a total of 43 square feet.
	/// 
	/// All numbers in the elves' list are in feet. How many total square feet of wrapping paper should they order?
	/// 
	/// --- Part Two ---
	/// 
	/// The elves are also running low on ribbon. Ribbon is all the same width, so they only have to worry about the length they need to 
	/// order, which they would again like to be exact.
	/// 
	/// The ribbon required to wrap a present is the shortest distance around its sides, or the smallest perimeter of any one face. Each 
	/// present also requires a bow made out of ribbon as well; the feet of ribbon required for the perfect bow is equal to the cubic feet of volume of the present. Don't ask how they tie the bow, though; they'll never tell.
	/// 
	/// For example:
	/// 
	///     A present with dimensions 2x3x4 requires 2+2+3+3 = 10 feet of ribbon to wrap the present plus 2*3*4 = 24 feet of ribbon 
	///     for the bow, for a total of 34 feet.
	///     A present with dimensions 1x1x10 requires 1+1+1+1 = 4 feet of ribbon to wrap the present plus 1*1*10 = 10 feet of ribbon 
	///     for the bow, for a total of 14 feet.
	/// 
	/// How many total feet of ribbon should they order?
	/// </summary>
	public class Day_02
	{
		public static string Input => "3x11x24\r\n13x5x19\r\n1x9x27\r\n24x8x21\r\n6x8x17\r\n19x18x22\r\n10x9x12\r\n12x2x5\r\n26x6x11\r\n9x23x15\r\n12x8x17\r\n13x29x10\r\n28x18x6\r\n22x28x26\r\n1x5x11\r\n29x26x12\r\n8x28x29\r\n27x4x21\r\n12x7x16\r\n7x4x23\r\n15x24x8\r\n15x14x2\r\n11x6x29\r\n28x19x9\r\n10x3x1\r\n5x20x13\r\n10x25x1\r\n22x17x7\r\n16x29x3\r\n18x22x8\r\n18x11x19\r\n21x24x20\r\n4x7x17\r\n22x27x12\r\n1x26x6\r\n5x27x24\r\n29x21x3\r\n25x30x2\r\n21x26x2\r\n10x24x27\r\n10x16x28\r\n18x16x23\r\n6x5x26\r\n19x12x20\r\n6x24x25\r\n11x20x7\r\n4x8x5\r\n2x13x11\r\n11x17x1\r\n13x24x6\r\n22x29x16\r\n4x24x20\r\n10x25x10\r\n12x29x23\r\n23x27x12\r\n11x21x9\r\n13x2x6\r\n15x30x2\r\n8x26x24\r\n24x7x30\r\n22x22x8\r\n29x27x8\r\n28x23x27\r\n13x16x14\r\n9x28x20\r\n21x4x30\r\n21x20x20\r\n11x17x30\r\n9x14x22\r\n20x2x6\r\n10x11x14\r\n1x8x23\r\n23x19x19\r\n26x10x13\r\n21x12x12\r\n25x7x24\r\n1x28x17\r\n20x23x9\r\n2x24x27\r\n20x24x29\r\n1x3x10\r\n5x20x14\r\n25x21x3\r\n15x5x22\r\n14x17x19\r\n27x3x18\r\n29x23x19\r\n14x21x19\r\n20x8x3\r\n22x27x12\r\n24x15x18\r\n9x10x19\r\n29x25x28\r\n14x22x6\r\n4x19x28\r\n4x24x14\r\n17x19x17\r\n7x19x29\r\n28x8x26\r\n7x20x16\r\n11x26x29\r\n2x18x3\r\n12x7x18\r\n11x15x21\r\n24x7x26\r\n2x22x23\r\n2x30x5\r\n1x19x8\r\n15x29x10\r\n15x26x22\r\n20x16x14\r\n25x29x22\r\n3x13x19\r\n1x12x30\r\n3x15x27\r\n19x9x11\r\n30x8x21\r\n26x12x20\r\n11x17x19\r\n17x25x1\r\n19x24x12\r\n30x6x20\r\n11x19x18\r\n18x15x29\r\n18x8x9\r\n25x15x5\r\n15x6x26\r\n13x27x19\r\n23x24x12\r\n3x15x28\r\n17x10x10\r\n15x4x7\r\n15x27x7\r\n21x8x11\r\n9x18x2\r\n7x20x20\r\n17x23x12\r\n2x19x1\r\n7x26x26\r\n13x23x8\r\n10x3x12\r\n11x1x9\r\n1x11x19\r\n25x14x26\r\n16x10x15\r\n7x6x11\r\n8x1x27\r\n20x28x17\r\n3x25x9\r\n30x7x5\r\n17x17x4\r\n23x25x27\r\n23x8x5\r\n13x11x1\r\n15x10x21\r\n22x16x1\r\n12x15x28\r\n27x18x26\r\n25x18x5\r\n21x3x27\r\n15x25x5\r\n29x27x19\r\n11x10x12\r\n22x16x21\r\n11x8x18\r\n6x10x23\r\n21x21x2\r\n13x27x28\r\n2x5x20\r\n23x16x20\r\n1x21x7\r\n22x2x13\r\n11x10x4\r\n7x3x4\r\n19x2x5\r\n21x11x1\r\n7x27x26\r\n12x4x23\r\n12x3x15\r\n25x7x4\r\n20x7x15\r\n16x5x11\r\n1x18x26\r\n11x27x10\r\n17x6x24\r\n19x13x16\r\n6x3x11\r\n4x19x18\r\n16x15x15\r\n1x11x17\r\n19x11x29\r\n18x19x1\r\n1x25x7\r\n8x22x14\r\n15x6x19\r\n5x30x18\r\n30x24x22\r\n11x16x2\r\n21x29x19\r\n20x29x11\r\n27x1x18\r\n20x5x30\r\n12x4x28\r\n3x9x30\r\n26x20x15\r\n18x25x18\r\n20x28x28\r\n21x5x3\r\n20x21x25\r\n19x27x22\r\n8x27x9\r\n1x5x15\r\n30x6x19\r\n16x5x15\r\n18x30x21\r\n4x15x8\r\n9x3x28\r\n18x15x27\r\n25x11x6\r\n17x22x15\r\n18x12x18\r\n14x30x30\r\n1x7x23\r\n27x21x12\r\n15x7x18\r\n16x17x24\r\n11x12x19\r\n18x15x21\r\n6x18x15\r\n2x21x4\r\n12x9x14\r\n19x7x25\r\n22x3x1\r\n29x19x7\r\n30x25x7\r\n6x27x27\r\n5x13x9\r\n21x4x18\r\n13x1x16\r\n11x21x25\r\n27x20x27\r\n14x25x9\r\n23x11x15\r\n22x10x26\r\n15x16x4\r\n14x16x21\r\n1x1x24\r\n17x27x3\r\n25x28x16\r\n12x2x29\r\n9x19x28\r\n12x7x17\r\n6x9x19\r\n15x14x24\r\n25x21x23\r\n26x27x25\r\n7x18x13\r\n15x10x6\r\n22x28x2\r\n15x2x14\r\n3x24x18\r\n30x22x7\r\n18x27x17\r\n29x18x7\r\n20x2x4\r\n4x20x26\r\n23x30x15\r\n5x7x3\r\n4x24x12\r\n24x30x20\r\n26x18x17\r\n6x28x3\r\n29x19x29\r\n14x10x4\r\n15x5x23\r\n12x25x4\r\n7x15x19\r\n26x21x19\r\n18x2x23\r\n19x20x3\r\n3x13x9\r\n29x21x24\r\n26x13x29\r\n30x27x4\r\n20x10x29\r\n21x18x8\r\n7x26x10\r\n29x16x21\r\n22x5x11\r\n17x15x2\r\n7x29x5\r\n6x18x15\r\n23x6x14\r\n10x30x14\r\n26x6x16\r\n24x13x25\r\n17x29x20\r\n4x27x19\r\n28x12x11\r\n23x20x3\r\n22x6x20\r\n29x9x19\r\n10x16x22\r\n30x26x4\r\n29x26x11\r\n2x11x15\r\n1x3x30\r\n30x30x29\r\n9x1x3\r\n30x13x16\r\n20x4x5\r\n23x28x11\r\n24x27x1\r\n4x25x10\r\n9x3x6\r\n14x4x15\r\n4x5x25\r\n27x14x13\r\n20x30x3\r\n28x15x25\r\n5x19x2\r\n10x24x29\r\n29x30x18\r\n30x1x25\r\n7x7x15\r\n1x13x16\r\n23x18x4\r\n1x28x8\r\n24x11x8\r\n22x26x19\r\n30x30x14\r\n2x4x13\r\n27x20x26\r\n16x20x17\r\n11x12x13\r\n28x2x17\r\n15x26x13\r\n29x15x25\r\n30x27x9\r\n2x6x25\r\n10x26x19\r\n16x8x23\r\n12x17x18\r\n26x14x22\r\n13x17x4\r\n27x27x29\r\n17x13x22\r\n9x8x3\r\n25x15x20\r\n14x13x16\r\n8x7x13\r\n12x4x21\r\n27x16x15\r\n6x14x5\r\n28x29x17\r\n23x17x25\r\n10x27x28\r\n1x28x21\r\n18x2x30\r\n25x30x16\r\n25x21x7\r\n2x3x4\r\n9x6x13\r\n19x6x10\r\n28x17x8\r\n13x24x28\r\n24x12x7\r\n5x19x5\r\n18x10x27\r\n16x1x6\r\n12x14x30\r\n1x2x28\r\n23x21x2\r\n13x3x23\r\n9x22x10\r\n10x17x2\r\n24x20x11\r\n30x6x14\r\n28x1x16\r\n24x20x1\r\n28x7x7\r\n1x24x21\r\n14x9x7\r\n22x8x15\r\n20x1x21\r\n6x3x7\r\n7x26x14\r\n5x7x28\r\n5x4x4\r\n15x7x28\r\n30x16x23\r\n7x26x2\r\n1x2x30\r\n24x28x20\r\n5x17x28\r\n4x15x20\r\n15x26x2\r\n1x3x23\r\n22x30x24\r\n9x20x16\r\n7x15x2\r\n6x21x18\r\n21x21x29\r\n29x10x10\r\n4x3x23\r\n23x2x18\r\n29x24x14\r\n29x29x16\r\n22x28x24\r\n21x18x24\r\n16x21x6\r\n3x9x22\r\n9x18x4\r\n22x9x9\r\n12x9x13\r\n18x21x14\r\n7x8x29\r\n28x28x14\r\n1x6x24\r\n11x11x3\r\n8x28x6\r\n11x16x10\r\n9x16x16\r\n6x6x19\r\n21x5x12\r\n15x17x12\r\n3x6x29\r\n19x1x26\r\n10x30x25\r\n24x26x21\r\n1x10x18\r\n6x1x16\r\n4x17x27\r\n17x11x27\r\n15x15x21\r\n14x23x1\r\n8x9x30\r\n22x22x25\r\n20x27x22\r\n12x7x9\r\n9x26x19\r\n26x25x12\r\n8x8x16\r\n28x15x10\r\n29x18x2\r\n25x22x6\r\n4x6x15\r\n12x18x4\r\n10x3x20\r\n17x28x17\r\n14x25x13\r\n14x10x3\r\n14x5x10\r\n7x7x22\r\n21x2x14\r\n1x21x5\r\n27x29x1\r\n6x20x4\r\n7x19x23\r\n28x19x27\r\n3x9x18\r\n13x17x17\r\n18x8x15\r\n26x23x17\r\n10x10x13\r\n11x5x21\r\n25x15x29\r\n6x23x24\r\n10x7x2\r\n19x10x30\r\n4x3x23\r\n22x12x6\r\n11x17x16\r\n6x8x12\r\n18x20x11\r\n6x2x2\r\n17x4x11\r\n20x23x22\r\n29x23x24\r\n25x11x21\r\n22x11x15\r\n29x3x9\r\n13x30x5\r\n17x10x12\r\n10x30x8\r\n21x16x17\r\n1x5x26\r\n22x15x16\r\n27x7x11\r\n16x8x18\r\n29x9x7\r\n25x4x17\r\n10x21x25\r\n2x19x21\r\n29x11x16\r\n18x26x21\r\n2x8x20\r\n17x29x27\r\n25x27x4\r\n14x3x14\r\n25x29x29\r\n26x18x11\r\n8x24x28\r\n7x30x24\r\n12x30x22\r\n29x20x6\r\n3x17x1\r\n6x15x14\r\n6x22x20\r\n13x26x26\r\n12x2x1\r\n7x14x12\r\n15x16x11\r\n3x21x4\r\n30x17x29\r\n9x18x27\r\n11x28x16\r\n22x3x25\r\n18x15x15\r\n2x30x12\r\n3x27x22\r\n10x8x8\r\n26x16x14\r\n15x2x29\r\n12x10x7\r\n21x20x15\r\n2x15x25\r\n4x14x13\r\n3x15x13\r\n29x8x3\r\n7x7x28\r\n15x10x24\r\n23x15x5\r\n5x7x14\r\n24x1x22\r\n1x11x13\r\n26x4x19\r\n19x16x26\r\n5x25x5\r\n17x25x14\r\n23x7x14\r\n24x6x17\r\n5x13x12\r\n20x20x5\r\n22x29x17\r\n11x17x29\r\n25x6x4\r\n29x8x16\r\n28x22x24\r\n24x23x17\r\n16x17x4\r\n17x8x25\r\n22x9x13\r\n24x4x8\r\n18x10x20\r\n21x23x21\r\n13x14x12\r\n23x26x4\r\n4x10x29\r\n2x18x18\r\n19x5x21\r\n2x27x23\r\n6x29x30\r\n21x9x20\r\n6x5x16\r\n25x10x27\r\n5x29x21\r\n24x14x19\r\n19x11x8\r\n2x28x6\r\n19x25x6\r\n27x1x11\r\n6x8x29\r\n18x25x30\r\n4x27x26\r\n8x12x1\r\n7x17x25\r\n7x14x27\r\n12x9x5\r\n14x29x13\r\n18x17x5\r\n23x1x3\r\n28x5x13\r\n3x2x26\r\n3x7x11\r\n1x8x7\r\n12x5x4\r\n2x30x21\r\n16x30x11\r\n3x26x4\r\n16x9x4\r\n11x9x22\r\n23x5x6\r\n13x20x3\r\n4x3x2\r\n14x10x29\r\n11x8x12\r\n26x15x16\r\n7x17x29\r\n18x19x18\r\n8x28x4\r\n22x6x13\r\n9x23x7\r\n11x23x20\r\n13x11x26\r\n15x30x13\r\n1x5x8\r\n5x10x24\r\n22x25x17\r\n27x20x25\r\n30x10x21\r\n16x28x24\r\n20x12x8\r\n17x25x1\r\n30x14x9\r\n14x18x6\r\n8x28x29\r\n12x18x29\r\n9x7x18\r\n6x12x25\r\n20x13x24\r\n22x3x12\r\n5x23x22\r\n8x10x17\r\n7x23x5\r\n10x26x27\r\n14x26x19\r\n10x18x24\r\n8x4x4\r\n16x15x11\r\n3x14x9\r\n18x5x30\r\n29x12x26\r\n16x13x12\r\n15x10x7\r\n18x5x26\r\n14x1x6\r\n10x8x29\r\n3x4x9\r\n19x4x23\r\n28x17x23\r\n30x7x17\r\n19x5x9\r\n26x29x28\r\n22x13x17\r\n28x2x1\r\n20x30x8\r\n15x13x21\r\n25x23x19\r\n27x23x1\r\n4x6x23\r\n29x29x24\r\n5x18x7\r\n4x6x30\r\n17x15x2\r\n27x4x2\r\n25x24x14\r\n28x8x30\r\n24x29x5\r\n14x30x14\r\n10x18x19\r\n15x26x22\r\n24x19x21\r\n29x23x27\r\n21x10x16\r\n7x4x29\r\n14x21x3\r\n21x4x28\r\n17x16x15\r\n24x7x13\r\n21x24x15\r\n25x11x16\r\n10x26x13\r\n23x20x14\r\n20x29x27\r\n14x24x14\r\n14x23x12\r\n18x6x5\r\n3x18x9\r\n8x18x19\r\n20x26x15\r\n16x14x13\r\n30x16x3\r\n17x13x4\r\n15x19x30\r\n20x3x8\r\n13x4x5\r\n12x10x15\r\n8x23x26\r\n16x8x15\r\n22x8x11\r\n12x11x18\r\n28x3x30\r\n15x8x4\r\n13x22x13\r\n21x26x21\r\n29x1x15\r\n28x9x5\r\n27x3x26\r\n22x19x30\r\n4x11x22\r\n21x27x20\r\n22x26x7\r\n19x28x20\r\n24x23x16\r\n26x12x9\r\n13x22x9\r\n5x6x23\r\n20x7x2\r\n18x26x30\r\n3x6x28\r\n24x18x13\r\n28x19x16\r\n25x21x25\r\n25x19x23\r\n22x29x10\r\n29x19x30\r\n4x7x27\r\n5x12x28\r\n8x26x6\r\n14x14x25\r\n17x17x2\r\n5x27x11\r\n8x2x2\r\n3x20x24\r\n26x10x9\r\n22x28x27\r\n18x15x20\r\n12x11x1\r\n5x14x30\r\n7x3x16\r\n2x16x16\r\n18x20x15\r\n13x14x29\r\n1x17x12\r\n13x5x23\r\n19x4x10\r\n25x19x11\r\n15x17x14\r\n1x28x27\r\n11x9x28\r\n9x10x18\r\n30x11x22\r\n21x21x20\r\n2x1x5\r\n2x25x1\r\n7x3x4\r\n22x15x29\r\n21x28x15\r\n12x12x4\r\n21x30x6\r\n15x10x7\r\n10x14x6\r\n21x26x18\r\n14x25x6\r\n9x7x11\r\n22x3x1\r\n1x16x27\r\n1x14x23\r\n2x13x8\r\n14x19x11\r\n21x26x1\r\n4x28x13\r\n12x16x20\r\n21x13x9\r\n3x4x13\r\n14x9x8\r\n21x21x12\r\n27x10x17\r\n6x20x6\r\n28x23x23\r\n2x28x12\r\n8x10x10\r\n3x9x2\r\n20x3x29\r\n19x4x16\r\n29x24x9\r\n26x20x8\r\n15x28x26\r\n18x17x10\r\n7x22x10\r\n20x15x9\r\n6x10x8\r\n7x26x21\r\n8x8x16\r\n15x6x29\r\n22x30x11\r\n18x25x8\r\n6x21x20\r\n7x23x25\r\n8x25x26\r\n11x25x27\r\n22x18x23\r\n3x2x14\r\n16x16x1\r\n15x13x11\r\n3x9x25\r\n29x25x24\r\n9x15x1\r\n12x4x1\r\n23x30x20\r\n3x1x23\r\n6x10x29\r\n28x13x24\r\n4x19x17\r\n6x6x25\r\n27x29x17\r\n12x13x2\r\n10x7x13\r\n14x15x8\r\n22x2x3\r\n27x17x19\r\n23x10x16\r\n5x9x25\r\n9x25x14\r\n11x18x6\r\n18x10x12\r\n9x4x15\r\n7x16x14\r\n17x24x10\r\n11x4x6\r\n12x9x17\r\n22x18x12\r\n6x24x24\r\n6x22x23\r\n5x17x30\r\n6x9x5\r\n17x20x10\r\n6x8x12\r\n14x17x13\r\n29x10x17\r\n22x4x5\r\n10x19x30\r\n22x29x11\r\n10x12x29\r\n21x22x26\r\n16x6x25\r\n1x26x24\r\n30x17x16\r\n27x28x5\r\n30x13x22\r\n7x26x12\r\n11x24x30\r\n1x17x25\r\n22x1x3\r\n29x24x6\r\n4x8x24\r\n13x9x20\r\n8x12x9\r\n21x25x4\r\n23x23x28\r\n5x2x19\r\n29x3x15\r\n22x1x14\r\n3x23x30\r\n8x25x3\r\n15x8x14\r\n30x14x6\r\n23x27x24\r\n19x1x2\r\n10x9x13\r\n13x8x7\r\n8x13x22\r\n5x15x20\r\n17x14x8\r\n5x11x20\r\n5x10x27\r\n24x17x19\r\n21x2x3\r\n15x30x26\r\n21x19x15\r\n2x7x23\r\n13x17x25\r\n30x15x19\r\n26x4x10\r\n2x25x8\r\n9x9x10\r\n2x25x8\r\n19x21x30\r\n17x26x12\r\n7x5x10\r\n2x22x14\r\n10x17x30\r\n1x8x5\r\n23x2x25\r\n22x29x8\r\n13x26x1\r\n26x3x30\r\n25x17x8\r\n25x18x26\r\n26x19x15\r\n8x28x10\r\n12x16x29\r\n30x6x29\r\n28x19x4\r\n27x26x18\r\n15x23x17\r\n5x21x30\r\n8x11x13\r\n2x26x7\r\n19x9x24\r\n3x22x23\r\n6x7x18\r\n4x26x30\r\n13x25x20\r\n17x3x15\r\n8x20x18\r\n23x18x23\r\n28x23x9\r\n16x3x4\r\n1x29x14\r\n20x26x22\r\n3x2x22\r\n23x8x17\r\n19x5x17\r\n21x18x20\r\n17x21x8\r\n30x28x1\r\n29x19x23\r\n12x12x11\r\n24x18x7\r\n21x18x14\r\n14x26x25\r\n9x11x3\r\n10x7x15\r\n27x6x28\r\n14x26x4\r\n28x4x1\r\n22x25x29\r\n6x26x6\r\n1x3x13\r\n26x22x12\r\n6x21x26\r\n23x4x27\r\n26x13x24\r\n5x24x28\r\n22x16x7\r\n3x27x24\r\n19x28x2\r\n11x13x9\r\n29x16x22\r\n30x10x24\r\n14x14x22\r\n22x23x16\r\n14x8x3\r\n20x5x14\r\n28x6x13\r\n3x15x25\r\n4x12x22\r\n15x12x25\r\n10x11x24\r\n7x7x6\r\n8x11x9\r\n21x10x29\r\n23x28x30\r\n8x29x26\r\n16x27x11\r\n1x10x2\r\n24x20x16\r\n7x12x28\r\n28x8x20\r\n14x10x30\r\n1x19x6\r\n4x12x20\r\n18x2x7\r\n24x18x17\r\n16x11x10\r\n1x12x22\r\n30x16x28\r\n18x12x11\r\n28x9x8\r\n23x6x17\r\n10x3x11\r\n5x12x8\r\n22x2x23\r\n9x19x14\r\n15x28x13\r\n27x20x23\r\n19x16x12\r\n19x30x15\r\n8x17x4\r\n10x22x18\r\n13x22x4\r\n3x12x19\r\n22x16x23\r\n11x8x19\r\n8x11x6\r\n7x14x7\r\n29x17x29\r\n21x8x12\r\n21x9x11\r\n20x1x27\r\n1x22x11\r\n5x28x4\r\n26x7x26\r\n30x12x18\r\n29x11x20\r\n3x12x15\r\n24x25x17\r\n14x6x11\r\n";

		public static long PuzzleA(string input) => 
			GetBoxArray(input).
			Sum(x => x.SurfaceArea + x.SmallestSideArea);

		public static long PuzzleB(string input) => 
			GetBoxArray(input).
			Sum(x => x.ShortestPerimeter + x.Volume);

		private static Box[] GetBoxArray(string input)
		{
			const string Newline = "\r\n";

			return SanitizeInput(input).
				Split(Newline).
				Select(x => new Box(x)).
				ToArray();

			static string SanitizeInput(string input) =>
				input[^2..^0] == Newline ? input = input[..^2] : input;
		}

		private record Box(long Length, long Width, long Height)
		{
			private const char Delimiter = 'x';

			public Box(string input) : this(0, 0, 0)
			{
				string[] inputArray = input.Split(Delimiter);

				if (inputArray.Length == 3)
				{
					Length = long.Parse(inputArray[0]);
					Width = long.Parse(inputArray[1]);
					Height = long.Parse(inputArray[2]);
				}
				else
					throw new NotImplementedException();
			}

			public long AreaLengthWidth => Length * Width;
			public long AreaWidthHeight => Width * Height;
			public long AreaHeightLength => Height * Length;

			public long SurfaceArea => (2 * AreaLengthWidth) + (2 * AreaWidthHeight) + (2 * AreaHeightLength);			
			public long SmallestSideArea => new long[] { AreaLengthWidth, AreaWidthHeight, AreaHeightLength }.Min();

			public long ShortestPerimeter => 
				new long[] { Length, Width, Height }.
					Order().
					SkipLast(1).
					Sum() * 2;

			public long Volume => Length * Width * Height;
		}
	}
}
