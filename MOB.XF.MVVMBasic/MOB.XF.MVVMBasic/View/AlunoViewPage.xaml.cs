using MOB.XF.MVVMBasic.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.MVVMBasic.View
{
    public partial class AlunoViewPage : ContentPage
    {
        AlunoViewModel vmAluno;

        public AlunoViewPage()
        {
            var aluno = AlunoViewModel.GetAluno();
            vmAluno = new AlunoViewModel(aluno);
            BindingContext = vmAluno;
        }
    }
}
