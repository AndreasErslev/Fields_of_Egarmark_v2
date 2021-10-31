using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.UI
{
    public interface IDisplay
    {
        string ChooseAttack();
        string CharacterSelect_Name();
        string CharacterSelect_Choice();
        string CharacterSelect_Invalid();


    }
}
