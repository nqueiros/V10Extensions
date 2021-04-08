using Primavera.Extensibility.Internal.Editors;
using Primavera.Extensibility.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;


namespace DEMO.GLOBAL
{
    public class UtilLigacaoCBL : Primavera.Extensibility.Internal.Editors.UtilLigacaoCBL
    {
        public override void AntesDeIntegrarCBL(ref bool Cancel, ExtensibilityEventArgs e)
        {
            base.AntesDeIntegrarCBL(ref Cancel, e);

            PSO.Dialogos.MostraMensagem(StdPlatBS100.StdBSTipos.TipoMsg.PRI_SimplesOk, "AntesDeIntegrarCBL", StdPlatBS100.StdBSTipos.IconId.PRI_Informativo);
        }
    }
}
