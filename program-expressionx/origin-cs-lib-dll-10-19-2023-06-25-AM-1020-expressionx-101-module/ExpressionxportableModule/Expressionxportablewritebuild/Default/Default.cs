using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public static ExpressionxportablewritebuildModule Default(Expressionxportable[] array_EXPRESSIONXPORTABLE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
        {
            ExpressionxportablewritebuildModule module;

            module = new ExpressionxportablewritebuildModule();

            var inflect = new Object[2];

            inflect[0] = array_EXPRESSIONXPORTABLE;

            inflect[1] = value_EXPRESSIONXPORTABLELAYOUT;

            ExpressionxportablewritebuildCycle.XZeroth = new XZeroth(inflect);

            module = module.XOne(module);

            module = module.XTwo(module);

            module = module.XThree(module);

            module = module.XFour(module);

            module = module.XFive(module);

            module = module.XSix(module);

            module = module.XSeven(module);

            module = module.XEight(module);

            Expressionxportablebuild expressionxportablebuild;

            expressionxportablebuild = new Expressionxportablebuild();

            expressionxportablebuild.Level = ExpressionxportablewritebuildCycle.XPrimary.XSingle.LevelArray;

            expressionxportablebuild.LevelLevel = ExpressionxportablewritebuildCycle.XSecondary.XDouble.LevelArray;

            expressionxportablebuild.LevelLevelLevel = ExpressionxportablewritebuildCycle.XTertiary.XTriple.LevelArray;

            expressionxportablebuild.LevelLevelLevelLevel = ExpressionxportablewritebuildCycle.XQuatenary.XQuadruple.LevelArray;

            expressionxportablebuild.LevelLevelLevelLevelLevel = ExpressionxportablewritebuildCycle.XQuinary.XQuadruple.LevelArray;

            expressionxportablebuild.LevelLevelLevelLevelLevelLevel = ExpressionxportablewritebuildCycle.XSenary.XSextuple.LevelArray;

            expressionxportablebuild.LevelLevelLevelLevelLevelLevelLevel = ExpressionxportablewritebuildCycle.XSeptenary.XSentuple.LevelArray;

            expressionxportablebuild.LevelLevelLevelLevelLevelLevelLevelLevel = ExpressionxportablewritebuildCycle.XOctonary.XOctuple.LevelArray;

            module.Expressionxportablebuild = expressionxportablebuild;

            return module;
        }
    }
}
