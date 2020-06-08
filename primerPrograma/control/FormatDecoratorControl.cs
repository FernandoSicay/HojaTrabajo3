
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace control{
    public abstract class FormatDecoratorControl : IFormatShow {

        //public FormatDecoratorControl() {
        //}

        protected IFormatShow decoratedFormat;

        /// <summary>
        /// @param decoratedFormat
        /// </summary>
        public  FormatDecoratorControl(IFormatShow decoratedFormat) {
            this.decoratedFormat = decoratedFormat;
        }
        public virtual void showData(String[] args){
        }

    }
}