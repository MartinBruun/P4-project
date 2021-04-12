using System;
using System.Collections.Generic;
using System.Security;
using System.Threading;
using System.Xml.Schema;
using Antlr4.Runtime.Misc;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.MachineSettings
{
    public class MachineSettingNodeExtractor : OGBaseVisitor<MachineSettingNode>
    {
        public Dictionary<string,MachineSettingNode> MachineSettings { get; set; }
        private SizePropertyNodeExtractor _sizePropNodeNodeExtractor = new SizePropertyNodeExtractor();
        private WorkAreaSettingExtractor _workAreaExtractor = new WorkAreaSettingExtractor();

        public override MachineSettingNode VisitProg(OGParser.ProgContext context)
        {
            OGParser.MachineSettingsContext machineSettings = context.settings ?? throw new ArgumentNullException("context.settings");
            MachineSettingNode res = VisitMachineSettings(machineSettings);
            if (res != null)
            {
                return res;
            }

            return null;
        }

        public override MachineSettingNode VisitMachineSettings(OGParser.MachineSettingsContext context)
        {
            OGParser.MachineModsContext machineModifications = context.machineModifications;
            return ExtractMachineSettingsNode(machineModifications);
        }

        public  MachineSettingNode ExtractMachineSettingsNode(OGParser.MachineModsContext context)
        {
            try
            {
                OGParser.MachineModifiersContext modifiersContext =
                    (OGParser.MachineModifiersContext) context;
                return VisitMachineModifiers(modifiersContext);
            }
            catch (InvalidCastException e)
            {
            }

            OGParser.EndOfMachineModifiersContext noModierfier =
                (OGParser.EndOfMachineModifiersContext) context;
            return null;
        }




        public override MachineSettingNode VisitMachineModifiers(OGParser.MachineModifiersContext context)
        {
            OGParser.MachineModsContext machineMods = context.machineModifications;
            OGParser.WorkAreaModContext workAreaContext = context.workAreaModifications;
            if (workAreaContext != null && !workAreaContext.IsEmpty)
            {
                return _workAreaExtractor.ExtractWorkAreaNode(workAreaContext);
            }

            if (context.machineModifications != null && !context.machineModifications.IsEmpty)
            {
                
                return ExtractMachineSettingsNode(context.machineModifications);
            }

            throw new AstNodeCreationException("MachineModifiers did not contain workarea or other machine modifications");
        }
    }

    public class WorkAreaSettingExtractor : OGBaseVisitor<WorkAreaSettingNode>
    {
        private SizePropertyNodeExtractor _sizePropNodeNodeExtractor = new SizePropertyNodeExtractor();

        public WorkAreaSettingNode ExtractWorkAreaNode(OGParser.WorkAreaModContext context)
        {

            try
            {
                
                //This conversion must happen, as WorkAreaMod is labeled as workAeaModifier and nothing 
                //else.
                OGParser.WorkAreaModifierContext workProperties;

                workProperties = (OGParser.WorkAreaModifierContext) context;

                OGParser.WorkAreaModPrptsContext p = workProperties.workAreaModificationProperties;
                OGParser.WorkAreaModifierPropertiesContext workAreaMods =
                        (OGParser.WorkAreaModifierPropertiesContext) p;
                SizePropertyNode result = _sizePropNodeNodeExtractor.VisitWorkAreaModifierProperties(workAreaMods);

                if (result != null)
                {
                    
                    return result;
                }
                else
                {
                    throw new AstNodeCreationException("No size of work area defined!");
                }
            }
            catch (Exception e)
            {
                throw new AstNodeCreationException("Context error: WorkAreaModContext conversion. " + e.Message);
            }
        }
    }

    public class SizePropertyNodeExtractor : OGBaseVisitor< SizePropertyNode>
    {
        private static int extractedSizeNodes = 0;
        public override SizePropertyNode VisitWorkAreaModifierProperties(OGParser.WorkAreaModifierPropertiesContext context)
        {

            if (context.sizeProperty != null && !context.sizeProperty.IsEmpty)
            {
                SizePropertyNode result = null;
                OGParser.SizePrptContext p = context.sizeProperty;
                if (p != null)
                {
                    result = ExtractSizePropertyNode(p);
                    extractedSizeNodes++;
                }
                
                if (extractedSizeNodes > 1)
                {
                    throw new AstNodeCreationException("Too many sizes of work area defined!");
                }
                else
                {
                    //Check if there are more workareamodifiers to go through
                    try
                    {
                        OGParser.WorkAreaModPrptsContext x = context.workAreaModificationProperties;
                        OGParser.WorkAreaModifierPropertiesContext workAreaMods =
                            (OGParser.WorkAreaModifierPropertiesContext) x;
                        VisitWorkAreaModifierProperties(workAreaMods);
                    }
                    catch (InvalidCastException e)
                    { }
                   
                    return result;
                }
            }

            throw new AstNodeCreationException("No size of work area defined!");
        }

       

        public SizePropertyNode ExtractSizePropertyNode(OGParser.SizePrptContext context)
        {
            OGParser.SizePropertyContext sizeCont = (OGParser.SizePropertyContext) context;
            return VisitSizeProperty(sizeCont);
        }
        
        public override SizePropertyNode VisitSizeProperty(
            [NotNull] OGParser.SizePropertyContext context)
        {
            MathNodeExtractor _mathNodeExtractor = new MathNodeExtractor();
            MathNode xMin = _mathNodeExtractor.ExtractMathNode(context.workAreaVariables.xmin);
            MathNode xMax = _mathNodeExtractor.ExtractMathNode(context.workAreaVariables.xmax);
            MathNode yMin = _mathNodeExtractor.ExtractMathNode(context.workAreaVariables.ymax);
            MathNode yMax = _mathNodeExtractor.ExtractMathNode(context.workAreaVariables.ymax);
            SizePropertyNode sizePropNode  = new SizePropertyNode(xMin, xMax, yMin, yMax);

            return new SizePropertyNode(xMin, xMax, yMin, yMax);
        }


    }
}