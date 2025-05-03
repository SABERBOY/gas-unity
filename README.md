# Unity GAS

![gas-unity-banner](README/Assets/gas-unity-banner.png)

## Overview

This project implements a **Gameplay Ability System (GAS)** in Unity. The GAS provides a framework for defining and executing abilities for characters in a game, allowing for modular, reusable, and scalable gameplay mechanics.

## Features

Each ability in this system is composed of multiple interchangeable **ScriptableObjects**, making it easy for designers to create, modify, and balance abilities without needing to write code. This modular approach ensures that abilities can be customized and fine-tuned with ease, providing a flexible toolkit for game designers.

- **Ability Definitions**: Create and manage abilities with various effects, such as damage, healing, buffs, debuffs, and more.
- **Attribute System**: Manage character attributes (e.g., health, mana, stamina) and integrate them with abilities.
- **Pool System**: Use events to trigger and respond to ability-related actions to release objects when needed.

### Abilities

![gas-unity-abilities](README/Assets/gas-unity-abilities.gif)

The system allows for the creation of abilities that can perform a wide range of actions. Each ability can have different components, including:

- **Targeting System**: Define and handle different targeting methods for abilities.

  - Area-of-effect (AoE)
    - Circle Zone
    - Square Zone
    - _More to come (WIP)_
  - Single-target
  - Self-targeting.
  - Directional.

- **Cooldown and Cost Management**: Implement cooldowns and mana cost for abilities:

  - Time cooldown
  - Stack cooldown
  - Mana cost

- **Filters**: Define criteria to select only targets that meet specific requirements.

  - Tags (Player, Enemy..)
  - Health (Dead, Alive, Health Amount...)
  - _More to come (WIP)_

- **Effects**: Implement list of effects.

  - Health
    - Damage
    - Heal
  - Animation
    - Set Boolean variable
    - Set Float variable
    - Set Trigger variable
  - Camera
    - Camera Shake
  - Buff / Debuff
    - Stats
    - _More to come (WIP)_
  - Spawn
    - Spawn Prefab
    - Spawn Prefab at target
    - Spawn Projectile Prefab
    - Spawn Projectile Spray Prefab
    - Spawn Projectile Barrage Prefab
    - _More to come (WIP)_
  - Transform
    - Look At Target
  - Composite

    - Delay

  - _More to come (WIP)_

#### Ability Example

Let’s take the **Void Strikes** ability as an example and break it down.

![void-strikes-structure](README/Assets/Ability/void-strikes-structure.png)

It consists of:

- **ID** : voidSrikes
- **Name** : Void Srikes
- **Description**: Unleashes a spray of 5 void bullets, dealing damage.
- **Icon** : Image field
- **Mana Cost**: 25

* **Targeting Strategy**: Directional Targeting
  ![void-strikes-targeting](README/Assets/Ability/void-strikes-targeting.png)
* **Cooldown Strategy**: Timer Cooldown
  ![void-strikes-timer-cooldown](README/Assets/Ability/void-strikes-timer-cooldown.png)

- **Filter Strategies**: Enemy Filter
  ![void-strikes-enemy-filter](README/Assets/Ability/void-strikes-enemy-filter.png)
- **Effect Strategies**: Spawn Projectile Spray Prefab
  ![void-strikes-spawn](README/Assets/Ability/void-strikes-spawn.png)

  - Here's the projectile prefab
    ![void-strikes-projectile](README/Assets/Ability/void-strikes-projectile.png)

    **Collision Effect Stategies**:

    - Damage Effect
      ![void-strikes-damage](README/Assets/Ability/void-strikes-damage.png)

    - Camera Shake
      ![void-strikes-camera-shake](README/Assets/Ability/void-strikes-camera-shake.png)

### Stats and Derived Stats

![gas-unity-stats](README/Assets/gas-unity-stats.gif)

The GAS includes a robust system for managing character stats and derived stats, which are used to calculate various in-game effects and outcomes. These stats are crucial in determining a character's effectiveness in combat, resource management, and overall gameplay performance.

#### Base Stats

Base stats are the fundamental attributes of a character. These stats influence the derived stats and directly affect the character's capabilities. The following base stats are included:

- **Constitution**:
  - Increases the maximum amount of health a character can have.
- **Endurance**:
  - Increases the maximum amount of stamina a character can possess.
  - Accelerates the rate at which a character replenishes stamina.
- **Strength**:

  - Enhances the damage a character deals through physical attacks.
  - Increases the maximum weight of items a character can carry without penalties. _(Weight system not yet implemented)_

- **Dexterity**:
  - Improves a character's ability to land hits on a target. _(Accuracy system not yet implemented)_
  - Increases the rate at which a character can perform consecutive attacks. _(Attack speed system not yet implemented)_
  - Raises the likelihood of a character landing a critical hit, causing extra damage. _(Critical Hit Chance system not yet implemented)_
  - Increases a character's ability to avoid incoming attacks. _(Evasion system not yet implemented)_
  - Enhances the speed at which a character moves across the game world. _(Movement speed system not yet implemented)_
- **Intelligence**:
  - Boosts the amount of damage a character inflicts with magical abilities.
  - Boosts a character's ability to resist or reduce magic damage taken
- **Luck**: System not yed implemented.
- **Charisma**: System not yed implemented.
- **Wisdom**:
  - Reduces the time it takes for a character's abilities to become usable again after being cast.
  - Increases the maximum amount of mana available for casting spells.
  - Accelerates the rate at which a character replenishes mana.

These stats are designed to provide a deep and flexible system for character customization and progression, allowing for a wide range of gameplay styles and strategies.

#### Derived Stats

Derived stats are calculated based on the base stats and determine various in-game effects. These stats are automatically updated when the base stats change. The following derived stats are included:

- **MaxHealth**: The maximum amount of health a character can have.
- **MaxMana**: The maximum amount of mana a character can have.
- **MaxStamina**: The maximum amount of stamina a character can have.
- **MagicDamage**: The amount of damage dealt by magical abilities.
- **PhysicalDamage**: The amount of damage dealt by physical attacks.
- **Accuracy**: The likelihood of hitting a target. _(Not yet implemented)_
- **Evasion**: The likelihood of avoiding an attack. _(Not yet implemented)_
- **CriticalHitChance**: The chance of dealing a critical hit. _(Not yet implemented)_
- **MovementSpeed**: The speed at which a character moves. _(Not yet implemented)_
- **AttackSpeed**: The speed at which a character can attack. _(Not yet implemented)_
- **MagicResistance**: The character's ability to resist magical damage.
- **PhysicalResistance**: The character's ability to resist physical damage.
- **HealthRegeneration**: The rate at which a character regenerates health over time.
- **StaminaRegeneration**: The rate at which a character regenerates stamina over time.
- **ManaRegeneration**: The rate at which a character regenerates mana over time.
- **AbilityCooldown**: The reduction in cooldown time for abilities.
- **MaxWeight**: The maximum amount of weight a character can carry. _(Not yet implemented)_




好的，没问题。以下是将卡牌塔防游戏中的炮塔、敌人相关属性以及卡牌加成方式整理成的表格，方便您查看和编辑：

**卡牌塔防游戏属性列表**

| 类别         | 属性名称 (中文)            | 英文名称 / 缩写 (参考)   | 描述                                                                 | 卡牌加成方式示例 (或相关性说明)                                                                                                |
| :----------- | :------------------------- | :----------------------- | :------------------------------------------------------------------- | :----------------------------------------------------------------------------------------------------------------------------- |
| **炮塔属性** | 最大生命值                 | Max HP                   | 炮塔的生命值上限，归零时被摧毁。                                     | 卡牌：+20% 最大生命值，卡牌：+100 最大生命值。                                                                                    |
|              | 护甲 / 防御                | Armor / Defense          | 减少受到的物理伤害。                                                 | 卡牌：+15 护甲，卡牌：使物理伤害降低额外 10%。                                                                                     |
|              | 魔法抗性 / 抗性            | Magic Resistance / Resist| 减少受到的魔法或元素伤害。                                           | 卡牌：+25% 魔法抗性，卡牌：使魔法伤害降低额外 5%。                                                                                |
|              | 攻击力                     | Damage                   | 每次攻击对敌人造成的伤害数值。                                       | 卡牌：+50 攻击力，卡牌：使攻击力提高 30%。                                                                                       |
|              | 攻击速度                   | Attack Speed             | 两次攻击之间的间隔时间越短，攻击越快。                               | 卡牌：攻击速度提高 25%，卡牌：攻击间隔减少 0.1 秒。                                                                             |
|              | 攻击范围                   | Range                    | 炮塔可以攻击到的最远距离。                                           | 卡牌：攻击范围扩大 1 格，卡牌：攻击范围提高 15%。                                                                                 |
|              | 弹道速度                   | Projectile Speed         | 炮塔发射的投射物飞行速度。                                           | 卡牌：投射物速度提高 50% (更快击中目标)。                                                                                      |
|              | 目标数量 / 溅射范围        | Targets / Splash Radius  | 一次攻击能影响的敌人数量或范围。                                     | 卡牌：额外攻击一个目标，卡牌：溅射范围扩大 0.5 格。                                                                                 |
|              | 暴击率                     | Critical Hit Chance      | 攻击时触发更高伤害的几率。                                           | 卡牌：暴击率提高 10%，卡牌：下次攻击必定暴击。                                                                                    |
|              | 暴击伤害倍率               | Critical Hit Damage Multi| 触发暴击时造成的伤害是基础伤害的多少倍。                           | 卡牌：暴击伤害提高 50% (例如从 1.5 倍提高到 2 倍)。                                                                             |
|              | 伤害类型                   | Damage Type              | 物理、魔法、元素等，与敌人的抗性或弱点相关。                         | 卡牌：将炮塔伤害类型转为火焰伤害，卡牌：攻击额外附带毒素伤害。                                                                   |
|              | 状态效果几率               | Status Effect Chance     | 攻击时施加负面状态（减速、眩晕等）的几率。                           | 卡牌：减速几率提高 15%，卡牌：攻击有 20% 几率眩晕敌人。                                                                           |
|              | 状态效果强度 / 持续时间    | Status Effect Strength/Duration | 施加的状态效果有多强或持续多久。                                     | 卡牌：减速效果提高 10% (从 30% 到 40%)，卡牌：中毒持续时间延长 2 秒。                                                              |
|              | 建造费用                   | Build Cost               | 建造该炮塔需要消耗的资源。                                           | 卡牌：使某种炮塔的建造费用降低 20%。                                                                                             |
|              | 升级费用                   | Upgrade Cost             | 升级该炮塔到下一等级所需的资源。                                     | 卡牌：使炮塔升级费用降低 15%。                                                                                                  |
|              | 资源产出                   | Resource Generation      | 如果是经济型炮塔，每隔一段时间产生的资源数量。                       | 卡牌：使资源产出提高 10%，卡牌：立即获得额外 50 资源。                                                                            |
|              | 特殊能力 / 技能            | Special Ability / Skill  | 炮塔可能拥有的主动或被动技能。                                       | 卡牌：使炮塔获得一个新的被动技能（如击杀回蓝），卡牌：使炮塔的主动技能冷却时间减少 10%。                                             |
|              | 法力值 / 能量上限          | Mana / Energy Max        | 如果特殊能力消耗资源，这是炮塔的上限。                               | 卡牌：法力值上限提高 50。                                                                                                       |
|              | 法力值 / 能量回复速度      | Mana / Energy Regen      | 炮塔每隔一段时间回复的法力值或能量。                                 | 卡牌：法力回复速度提高 1 点/秒。                                                                                                |
| **敌人属性** | 最大生命值                 | Max HP                   | 敌人能承受的伤害总量。                                               | (相关性：影响击杀所需时间，卡牌可能提供对高生命值敌人的额外伤害)                                                                    |
|              | 护甲 / 防御                | Armor / Defense          | 减少受到的物理伤害。                                                 | (相关性：影响物理伤害效率，卡牌可能提供护甲穿透效果或对高护甲敌人的加成)                                                             |
|              | 魔法抗性 / 抗性            | Magic Resistance / Resist| 减少受到的魔法或元素伤害。                                           | (相关性：影响魔法伤害效率，卡牌可能提供抗性穿透效果或对高抗性敌人的加成)                                                             |
|              | 移动速度                   | Movement Speed           | 敌人前进的速度，影响威胁程度。                                       | (相关性：影响减速效果的价值，卡牌可能增强减速效果或对快速敌人的伤害)                                                               |
|              | 属性弱点 / 抗性 / 免疫     | Elemental Weakness/Resist/Immunity | 对特定伤害类型的易伤或抗性。                                         | (相关性：影响选择炮塔伤害类型的策略，卡牌可能增强对弱点敌人的伤害或使炮塔伤害穿透免疫)                                                   |
|              | 状态效果抗性 / 免疫        | Status Effect Resist/Immunity | 对减速、眩晕等状态效果的抵抗能力或免疫。                             | (相关性：影响控制效果的价值，卡牌可能增强控制效果强度或穿透抗性)                                                                  |
| **卡牌效果类型** | 直接数值加成               | Direct Value Add         | 直接增加炮塔某个属性的数值。                                         | 卡牌示例：使目标炮塔攻击力 +50。                                                                                                |
|              | 百分比加成                 | Percentage Add           | 按比例增加炮塔某个属性的数值。                                       | 卡牌示例：使目标炮塔攻击速度 +25%。                                                                                             |
|              | 倍率加成                   | Multiplier               | 按倍数增加炮塔某个属性的数值。                                       | 卡牌示例：使目标炮塔暴击伤害 x 2倍。                                                                                            |
|              | 改变属性类型 / 附魔        | Change Type / Enchant    | 改变炮塔的伤害类型或附加额外伤害效果。                               | 卡牌示例：使目标炮塔的攻击附带火焰伤害，或将物理伤害转为火焰伤害。                                                               |
|              | 增加新属性 / 能力          | Add Attribute / Ability  | 使炮塔获得原本没有的属性或特殊能力。                                 | 卡牌示例：使目标炮塔获得溅射伤害能力，或获得击杀回血的被动。                                                                     |
|              | 修改行为 / 优先级          | Change Behavior / Priority | 改变炮塔的索敌目标优先级或其他行为模式。                             | 卡牌示例：使目标炮塔优先攻击护甲最低的敌人。                                                                                      |
|              | 全局 / 区域 / 类型加成     | Global / Area / Type Bonus | 对所有炮塔、特定区域或特定类型的炮塔提供加成。                       | 卡牌示例：场上所有火焰塔攻击力 +10%，或指定区域内所有炮塔攻击范围 +1 格。                                                         |
|              | 限时加成                   | Timed Bonus              | 加成效果只持续一段时间。                                             | 卡牌示例：使目标炮塔在接下来的 10 秒内攻击速度提高 50%。                                                                        |
|              | 触发式加成                 | Triggered Bonus          | 满足特定条件时（如击杀敌人、受到伤害）触发的临时加成。               | 卡牌示例：目标炮塔每次击杀敌人后，下次攻击伤害提高 20%。                                                                        |
|              | 卡牌自身属性               | Card Attributes          | 卡牌的使用费用、冷却时间、作用目标（单个、区域、所有）等。           | 卡牌示例：费用：3 资源，冷却时间：60 秒，目标：单个炮塔。                                                                       |

您可以复制此表格到电子表格软件（如 Excel, Google Sheets）或文档编辑器中进行进一步的编辑和管理。

希望这个表格能帮助您更清晰地规划您的游戏设计！
