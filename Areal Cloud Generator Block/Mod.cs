using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blocks
{

    public class Areal_Cloud_Generator : BlockMod
    {
        public override Version Version { get { return new Version("1.0"); } }
        public override string Name { get { return "ArealCloudGeneratorBlockMod)"; } }
        public override string DisplayName { get { return "Areal Cloud Generator Block Mod"; } }
        public override string BesiegeVersion { get { return "v0.45a"; } }
        public override string Author { get { return "覅是 wang_w571"; } }

        protected Block cloudSpawnerBlock = new Block()
            .ID(534)
            .BlockName("Areal Cloud Generator Bloc")
            .Obj(new List<Obj> { new Obj("ArealCloudGeneratorBlock.obj", //Obj
                                         "ArealCloudGeneratorBlockTexture.png", //贴图
                                         new VisualOffset(new Vector3(1f, 1f, 1f), //Scale
                                                          new Vector3(0f, 0f, 0f), //Position
                                                          new Vector3(0f, 0f, 0f)))//Rotation
            })
            ///在UI下方的选模块时的模样
            .IconOffset(new Icon(new Vector3(1.30f, 1.30f, 1.30f),  //Scale
                                 new Vector3(-0.11f, -0.13f, 0.00f),  //Position
                                 new Vector3(45f, 45f, 45f))) //Rotation
            .Components(new Type[] { typeof(CloudGeneratorScript), })

            ///给搜索用的关键词
            .Properties(new BlockProperties().SearchKeywords(new string[] {
                                                             "Block",
                                                             "Environment",
                                                             "Effects",
                                                             "云",
                                                             "Spawner",
                                             }))
            .Mass(0.5f)
            .ShowCollider(false)
            .CompoundCollider(new List<ColliderComposite> { new ColliderComposite(new Vector3(1, 1, 1), new Vector3(0f, 0f, 0.5f), new Vector3(0f, 0f, 0f)) })
            .NeededResources(new List<NeededResource> {
                                new NeededResource(ResourceType.Texture,("cloudTexture.png"))
            })
            .AddingPoints(new List<AddingPoint> {
                               (AddingPoint)new BasePoint(true, true)
                                                .Motionable(false,false,false)
                                                .SetStickyRadius(0.5f),
            });

        public override void OnLoad()
        {
            LoadBlock(cloudSpawnerBlock);//加载该模块
        }
        public override void OnUnload() { }
    }
    public class CloudGeneratorScript : BlockScript
    {

        public override void SafeAwake()
        {


        }

        public override void OnSave(XDataHolder data)
        {
            SaveMapperValues(data);
        }
        public override void OnLoad(XDataHolder data)
        {
            LoadMapperValues(data);
            if (data.WasSimulationStarted) return;
        }

        protected override void OnSimulateStart()
        {
        }

        protected override void OnSimulateFixedUpdate()
        {

        }
    }

}
