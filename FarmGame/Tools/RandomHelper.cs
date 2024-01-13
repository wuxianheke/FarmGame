using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FarmGame.Tools
{
    public class RandomHelper
    {
        private ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random());
        /// <summary>
        /// 返回进度条随机数
        /// </summary>
        /// <returns></returns>
        public Func<int> GetRandomProgressbarNumber()
        {
            return () => random.Value.Next(0, 101);
        }
    }
}
