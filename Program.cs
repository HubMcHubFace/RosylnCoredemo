using RosylynCore;
using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace RosylynCore
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateSampleViewModel();
        }

        static void GenerateSampleViewModel()
        {
            const string models = @"namespace Models
{
    public class Item
    {
        public string ItemName { get; set }
    }
}
";
            var node = CSharpSyntaxTree.ParseText(models).GetRoot();
            var viewModel = ViewModelGeneration.GenerateViewModel(node);

            if (viewModel != null)
            {
                Console.WriteLine(viewModel.ToFullString());
            }
            Console.ReadLine();
        }
    }
}