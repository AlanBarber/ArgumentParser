using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentParser
{
    public class Parser
    {
        private List<string> _parseTokens = new List<string>() {"/","-","--"};
        private string[] _args; 
        
        public Parser()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parser"/> class.
        /// </summary>
        /// <param name="args">The args.</param>
        public Parser(string[] args)
        {
            SetArguments(args);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parser"/> class.
        /// </summary>
        /// <param name="argumentOptions">The argument options.</param>
        public Parser(List<object> argumentOptions)
        {
            SetArgumentOptions(argumentOptions);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parser"/> class.
        /// </summary>
        /// <param name="args">The args.</param>
        /// <param name="argumentOptions">The argument options.</param>
        public Parser(string[] args, List<object> argumentOptions)
        {
            SetArguments(args);
            SetArgumentOptions(argumentOptions);
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name="args">The args.</param>
        public void SetArguments(string[] args)
        {
            _args = new string[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                _args[i] = args[i];
            }
        }

        /// <summary>
        /// Sets the argument options.
        /// </summary>
        /// <param name="argumentOptions">The argument options.</param>
        public void SetArgumentOptions(List<object> argumentOptions)
        {
            // do some stuff
        }

        /// <summary>
        /// Parses the specified args.
        /// </summary>
        /// <param name="args">The args.</param>
        public List<Argument> Parse(string[] args)
        {
            SetArguments(args);
            return Parse();
        }

        /// <summary>
        /// Parses the specified args.
        /// </summary>
        /// <param name="argumentOptions">The argument options.</param>
        public List<Argument> Parse(List<object> argumentOptions)
        {
            SetArgumentOptions(argumentOptions);
            return Parse();
        }

        /// <summary>
        /// Parses the specified args.
        /// </summary>
        /// <param name="args">The args.</param>
        /// <param name="argumentOptions">The argument options.</param>
        public List<Argument> Parse(string[] args, List<object> argumentOptions)
        {
            SetArguments(args);
            SetArgumentOptions(argumentOptions);
            return Parse();
        }

        /// <summary>
        /// Parses the specified args.
        /// </summary>
        public List<Argument> Parse()
        {
            // do some stuff
            return null;
        }

        public void DisplayHelp()
        {
            
        }

    }
}
