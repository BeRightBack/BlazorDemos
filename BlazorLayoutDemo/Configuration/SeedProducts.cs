using BlazorLayoutDemo.Data;
using BlazorLayoutDemo.Entity;

namespace BlazorLayoutDemo.Configuration;
public class SeedProducts
{
    private static CatalogDbContext? _context;

    public SeedProducts(CatalogDbContext context)
    {
        _context = context;
    }


    public static Task EnsureSeedDataAsync()
    {
        var _RogG7 = new Guid("337acae3-7adf-4372-8619-1cc9345c61ea");
        var _AcerPredatorGx = new Guid("c85f8f8b-3245-4be5-9fa7-96f1df2dbdc7");
        var _AsusGtx1080tiFounder = new Guid("9de9aad6-7dca-4861-842f-20021a2c5fa0");
        var _AsusGtx1070Strix = new Guid("d9122044-3401-4bee-aaac-9c7802a7027e");
        var _RogStrixRx480O8G = new Guid("5f1c200c-b551-4ceb-9273-3ccf9c4718da");
        var _IntelCorei77700K = new Guid("6176109c-2219-4013-a3f3-7cf90b60d8be");
        var _RazerBladeGTX1060 = new Guid("4701684d-f990-4829-8d5a-3d468155520f");
        var _AmdRyzen71800X = new Guid("62e79149-f655-4bb4-ab81-934690c80264");
        var _LogitechG502 = new Guid("5051b175-0b4c-4596-9b3d-7f47db3aa487");

        var laptop = new Guid("8c4825ef-8c4c-4162-b2e3-08d46c337976");
        var mouse = new Guid("572a88b0-17ef-4e6c-a806-ca35ad57a41b");
        var processors = new Guid("21e88188-057e-41e0-8746-57ec2fd76a51");
        var videocard = new Guid("fdc32bdd-013d-4ced-9106-c3e722e4650a");

        var acer = new Guid("609483bf-c285-4d67-92f3-08d46c31e55a");
        var amd = new Guid("c2c32a94-3a51-48be-9d1a-8a9a687bcb60");
        var asus = new Guid("8d942bc6-7407-417f-92f2-08d46c31e55a");
        var intel = new Guid("d96116b4-d107-4db2-bdbc-be493989d557");
        var logitech = new Guid("b54c872d-a32b-4f8a-8ae1-12b61167cecd");
        var razer = new Guid("0c69ba36-beb1-4054-b492-f361c836acc3");

        var numberOfCores = new Guid("18f698d1-7060-485e-b411-7949491f54db");
        var numberOfThreads = new Guid("af498fc2-aa53-4a36-b535-891428a92a84");
        var bit64Support = new Guid("473dd9cf-ec4d-452e-9e8a-88d9670cc75b");
        var accessories = new Guid("58f74c41-14b7-426f-aa46-ddbd73989292");
        var battery = new Guid("d957dae6-c254-4266-b45c-27fa04f00761");
        var brand = new Guid("8d7163a1-ef0b-442b-88ce-55363cd9ddbc");
        var buttons = new Guid("f8affde9-7566-448e-ba9f-d06de0fcd1b8");
        var color = new Guid("679ee965-7868-4812-8dad-b6f53e542ebd");
        var coolingDevice = new Guid("c6a04689-3a3d-4346-b233-a9078ee57f0d");
        var coreName = new Guid("739b9689-b4e5-4c30-8108-8cec7419aba9");
        var chipset = new Guid("f48d837a-22e1-43e1-967a-a989d5889f37");
        var cpuSocketType = new Guid("b9fe1b06-213a-4128-9329-250da2906852");
        var cudaCore = new Guid("e229d9c0-459c-44f9-8f7d-d670cfb4d1d6");
        var dimensions = new Guid("19dfc537-f02a-4c7d-9919-5b939d08186f");
        var display = new Guid("6144e4ab-722e-4b13-bffe-6f0ea8b168b2");
        var engineClock = new Guid("6dcd49e6-7aa5-4971-80d3-30be12898633");
        var features = new Guid("1cf7a9ef-11d9-4867-9c7d-ae7d7c46ba6c");
        var gamingSeries = new Guid("42f0a5df-e976-4ab6-adab-e260f9cef244");
        var graphic = new Guid("27201fbe-59d6-42a4-b698-a75dcb3e9f52");
        var graphicsEngine = new Guid("a0e252f2-39df-4f19-a139-260dd2935097");
        var handOrientation = new Guid("4f7d03ab-c9a1-489c-9736-7ce7a49f89de");
        var hyperThreadingSupport = new Guid("79136369-aadd-47e2-ac71-2511933881e5");
        var _interface = new Guid("eca1dc44-190e-4806-ba8a-1af16fbd8d24");
        var keyboard = new Guid("c2a6ac96-7de8-4bdc-a322-fc56f27c8fc8");
        var l2Cache = new Guid("282b9279-919d-4300-8109-eb568c02e839");
        var l3Cache = new Guid("f1c8f4aa-9693-4cda-b6e5-c9e967439577");
        var manufacturingTech = new Guid("1af15e3b-f60d-4d7d-a562-f7dff9a99f20");
        var maxTurboFrequency = new Guid("26eb8a9b-3b09-4f47-889c-28859a35b777");
        var maximumDpi = new Guid("f4b46786-9f8b-4b04-934c-8c43d270e9e1");
        var memory = new Guid("928a7270-7d70-4a37-9440-c650c2a6d782");
        var memoryClock = new Guid("20dabff6-aea8-4197-88a6-a3de73d9c36c");
        var memoryInterface = new Guid("d969d702-d7da-4eac-b203-2450c576bde7");
        var model = new Guid("3dd9d028-1c7e-4b48-81d9-d50e6b8ce900");
        var mouseAdjustableWeight = new Guid("886a0409-5f0e-4152-a57a-8917f3a7a43b");
        var mouseGripStyle = new Guid("70f098c7-2d41-4c3a-b0fd-60dad9afb5a2");
        var name = new Guid("fc3dcda5-f9f3-4b2f-b038-f42bc5fa6774");
        var networking = new Guid("f7af0f50-137c-4ce6-b27d-920c83d4ebc7");
        var operating = new Guid("ed46ee55-ac40-4d77-80be-69ab6b0d010c");
        var operatingFrequency = new Guid("a5f9adab-4415-415c-8bcc-dac939acfa2f");
        var operatingSystemSupported = new Guid("753f0fb5-4cef-474e-ab93-b9b8797dc407");
        var powerConnectors = new Guid("1ecc8164-69d8-4134-96a3-8ac89618be75");
        var processor = new Guid("75477c08-8245-4211-ab74-9c7c14d4dae9");
        var processorsType = new Guid("d073700d-c17e-41c8-a283-9abfeb8a8f6a");
        var resolution = new Guid("9ed7299e-1637-4809-a375-5d0bdff8b613");
        var scrollingCapability = new Guid("0030dbcc-041e-41d5-977c-5ecdd4ceb6c3");
        var series = new Guid("2ac500ca-e15a-4785-9654-3eef7f26fb1c");
        var software = new Guid("1c9cef2e-b9df-4c90-b88e-f45f7d688646");
        var storage = new Guid("8ad5f582-c787-4ba2-a49e-d8f8dd2ee621");
        var systemRequirement = new Guid("d5f23363-8404-4d34-8ef8-3a93babb8ad4");
        var thermalDesignPower = new Guid("a74cfddc-9450-4a3d-922b-e7670c9b7924");
        var trackingMethod = new Guid("583c2465-5e50-4f07-b2a3-4e0ba77bd374");
        var type = new Guid("f3c9d2a1-e05d-4837-9507-e08404098750");
        var videoMemory = new Guid("2db5ac64-a42d-4bad-8eba-d26ff4e7f727");
        var virtualizationTechnologySupport = new Guid("a73e43a3-d3d8-4b76-b1e6-274fb682d0a5");
        var vr = new Guid("88bcd475-ceb8-4ae3-a385-c3ec07b787e7");
        var webCam = new Guid("e611379b-5c1f-4286-8a54-9c8c45a5697d");
        var weight = new Guid("93d8b1f6-8a3d-41e5-b3d5-7513bd7f3b33");

        var i_RogG7Front = new Guid("1c34435f-2dc2-45fc-a903-7bca40eb5674");
        var i_RogG7Back = new Guid("cb7d5d64-283c-4d45-9c45-d48c9763956c");
        var i_Predator17XFront = new Guid("dd733338-513d-4e30-9e7f-d4b09f975dd3");
        var i_Predator17XBack = new Guid("f27092f1-2931-4dd5-ab7f-3ef2126c9cf8");
        var i_AsusGtx1080tiFounder = new Guid("af740663-4919-47dd-b2a5-a393af28bbd5");
        var i_AsusGtx1080tiFounder2 = new Guid("4ae5aa7a-b7b7-4b47-94d9-180876233776");
        var i_AsusGgtx1070Strix = new Guid("04096de0-531e-4f9d-848e-a2c36794181e");
        var i_RogStrixRx480O8G = new Guid("2f077ad1-ab0c-4ff0-864c-4b45e4c31d8c");
        var i_IntelCorei77700K = new Guid("e09f3dd2-a176-47b3-8518-2015eaef32cc");
        var i_TheRazerBladeFront = new Guid("06cf5fcf-be1f-4690-a9ae-69dc4c35bca7");
        var i_TheRazerBladeSlide = new Guid("4e6bbd99-d7a4-470d-bc47-2a6e39389e0a");
        var i_Ryzen71800x = new Guid("6449aee5-0618-41f5-9c81-dba6ba41870c");
        var i_LogitechG502Main = new Guid("9b1cd692-8d27-4661-a171-debe279a8961");
        var i_LogitechG502Side = new Guid("baabfd5a-7851-49b6-b67b-046877de431c");
        var i_LogitechG502Bottom = new Guid("139e1fb7-6f21-4d2c-8987-26091744fa4c");

        if (_context!.Database == null)
        {
            throw new Exception("DB is null");
        }


        if (!_context.Categories.Any())
        {
            var categoryList = new List<Category>
            {
                new() { Id = laptop, Name = "Laptop", SeoUrl = "Laptop", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now, ParentCategoryId = Guid.Empty },
                new() { Id = mouse, Name = "Mouse", SeoUrl = "Mouse", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now, ParentCategoryId = Guid.Empty },
                new() { Id = processors, Name = "Processors", SeoUrl = "Processors", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now, ParentCategoryId = Guid.Empty },
                new() { Id = videocard , Name = "Video Card", SeoUrl = "Video-Card", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now, ParentCategoryId = Guid.Empty }
            };
            _context.Categories.AddRange(categoryList);
            _context.SaveChanges();
        }

        if (!_context.Manufacturers.Any())
        {
            var manufacturerList = new List<Manufacturer>
            {
                new() { Id = acer, Name = "Acer", SeoUrl = "Acer", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = amd, Name = "AMD", SeoUrl = "AMD", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = asus, Name = "Asus", SeoUrl = "Asus", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = intel, Name = "Intel", SeoUrl = "Intel", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = logitech, Name = "Logitech", SeoUrl = "Logitech", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = razer, Name = "Razer", SeoUrl = "Razer", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now }
            };
            _context.Manufacturers.AddRange(manufacturerList);
            _context.SaveChanges();

        }

        if (!_context.Specifications.Any())
        {
            var specificationList = new List<Specification>
            {
                new() { Id = numberOfCores, Name = "# Cores", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = numberOfThreads, Name = "# of Threads", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = bit64Support, Name = "64-Bit Support", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = accessories, Name = "Accessories", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = battery, Name = "Battery", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = brand, Name = "Brand", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = buttons, Name = "Buttons", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = color, Name = "Color", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = coolingDevice, Name = "Cooling Device", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = coreName, Name = "Core Name", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = chipset, Name = "Chipset", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = cpuSocketType, Name = "CPU Socket Type", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = cudaCore, Name = "CUDA Core", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = dimensions, Name = "Dimensions", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = display, Name = "Display", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = engineClock, Name = "Engine Clock", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = features, Name = "Features", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = gamingSeries, Name = "Gaming Series", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = graphic, Name = "Graphic", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = graphicsEngine, Name = "Graphics Engine", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = handOrientation, Name = "Hand Orientation", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = hyperThreadingSupport, Name = "Hyper-Threading Support", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = _interface, Name = "Interface", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = keyboard, Name = "Keyboard", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = l2Cache, Name = "L2 Cache", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = l3Cache, Name = "L3 Cache", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = manufacturingTech, Name = "Manufacturing Tech", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = maxTurboFrequency, Name = "Max Turbo Frequency", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = maximumDpi, Name = "Maximum dpi", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = memory, Name = "Memory", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = memoryClock, Name = "Memory Clock", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = memoryInterface, Name = "Memory Interface", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = model, Name = "Model", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = mouseAdjustableWeight, Name = "Mouse Adjustable Weight", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = mouseGripStyle, Name = "Mouse Grip Style", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = name, Name = "Name", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = networking, Name = "Networking", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = operating, Name = "Operating", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = operatingFrequency, Name = "Operating Frequency", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = operatingSystemSupported, Name = "Operating System Supported", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = powerConnectors, Name = "Power Connectors", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = processor, Name = "Processor", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = processorsType, Name = "Processors Type", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = resolution, Name = "Resolution", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = scrollingCapability, Name = "Scrolling Capability", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = series, Name = "Series", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = software, Name = "Software", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = storage, Name = "Storage", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = systemRequirement, Name = "System Requirement", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = thermalDesignPower, Name = "Thermal Design Power", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = trackingMethod, Name = "Tracking Method", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = type, Name = "Type", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = videoMemory, Name = "Video Memory", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = virtualizationTechnologySupport, Name = "Virtualization Technology Support", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = vr, Name = "VR", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = webCam, Name = "WebCam", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now },
                new() { Id = weight, Name = "Weight", Published = true, DateAdded = DateTime.Now, DateModified = DateTime.Now }
            };
            _context.Specifications.AddRange(specificationList);
            _context.SaveChanges();

        }

        if (!_context.Images.Any())
        {
            var imageList = new List<Image>
            {
                new() { Id = i_RogG7Front, FileName = "/Images/test_images/ROG G701VI (7th Gen Intel Core).jpg" },
                new() { Id = i_RogG7Back, FileName = "/Images/test_images/ROG G701VI (7th Gen Intel Core) back.jpg" },
                new() { Id = i_Predator17XFront, FileName = "/Images/test_images/Predator_17X.png" },
                new() { Id = i_Predator17XBack, FileName = "/Images/test_images/Predator_17X back.png" },
                new() { Id = i_AsusGtx1080tiFounder, FileName = "/Images/test_images/asus gtx 1080 ti founder.jpg" },
                new() { Id = i_AsusGtx1080tiFounder2, FileName = "/Images/test_images/asus gtx 1080 ti founder 2.png" },
                new() { Id = i_AsusGgtx1070Strix, FileName = "/Images/test_images/asus gtx 1070 strix.png" },
                new() { Id = i_RogStrixRx480O8G, FileName = "/Images/test_images/rog strix rx480 O8G gaming.jpg" },
                new() { Id = i_IntelCorei77700K, FileName = "/Images/test_images/Intel Core i7-7700K.jpg" },
                new() { Id = i_TheRazerBladeFront, FileName = "/Images/test_images/The Razer Blade Front.jpg" },
                new() { Id = i_TheRazerBladeSlide, FileName = "/Images/test_images/The Razer Blade Slide.jpg" },
                new() { Id = i_Ryzen71800x, FileName = "/Images/test_images/ryzen 7 1800x.jpg" },
                new() { Id = i_LogitechG502Main, FileName = "/Images/test_images/Logitech G502 main.jpg" },
                new() { Id = i_LogitechG502Side, FileName = "/Images/test_images/Logitech G502 side.jpg" },
                new() { Id = i_LogitechG502Bottom, FileName = "/Images/test_images/Logitech G502 bottom.jpg" }
            };
            _context.Images.AddRange(imageList);
            _context.SaveChanges();

        }

        if (!_context.Products.Any())
        {


            var product = new Product // rog g7
            {
                Id = _RogG7,
                Name = "ROG G701VI (7th Gen Intel Core)",
                Description = "<strong>FEATURES AT-A-GLANCE</strong><hr /><ul><li>Latest-generation NVIDIA GTX 1080 8GB Graphics Card, Unlocked Intel Core i7-7820HK 2.9 GHz Processor (8M Cache, up to 3.9 GHz)</li><li>Overclocked 64GB DDR4 2800MHz RAM, 1TB NVMe PCIe SSD (512GB x2 RAID0), Windows 10 Pro, CM238 Express Chipset</li><li>17.3\u201D FHD 1920x1080 G-SYNC Display, 120Hz refresh rate, 178\u00B0 Viewing angles</li><li>1x HDMI 2.0 Port, 1x mini Displayport, 802.11ac WiFi 2x2, Bluetooth 4.1, 1x USB 3.1 Type C, 1x Thunderbolt Port (up to 20Gbit/s.), 1x RJ45 LAN Jack, 3x USB 3.0</li><li>Powerful battery rated 93WHrs, 6 cell Li-ion Battery Pack, ESS Sabre headphone DAC and amplifier, Anti-Ghosting (30-Key Rollover), ROG Macro Keys Illuminated Chiclet</li></ul><br /><strong>FEATURES</strong><hr /><h4><strong>OVERCLOCKING BEAST</strong></h4><br /><strong><img alt=\"\" src=\"https://smedia.webcollage.net/rwvfp/wc/cp/23137514/module/asus/_cp/products/1485198472421/tab-6f36d4a4-a37a-4a56-81e4-acfef128bc74/5073c8af-dbbb-4f63-8e51-0207ba6d97bd.jpg.w960.jpg\" style=\"height:320px; width:320px\" /></strong><br /><br />ROG G701VI OC Edition OC Edition is designed to be overclocked to maximum potential. It\u2019s equipped with an unlocked Intel Core i7-7820K processor.&nbsp;<br /><br />Overclock ROG G701 using ROG Gaming Center, providing access to three modes: Standard, Extreme, and Manual for quick and easy access to performance levels.<hr /><br /><strong>BLAZING FAST RAM, BLAZING FAST SSD<br /><br /><img alt=\"\" src=\"https://smedia.webcollage.net/rwvfp/wc/cp/23137514/module/asus/_cp/products/1485198472421/tab-6f36d4a4-a37a-4a56-81e4-acfef128bc74/4dad08b7-ebca-4415-9029-7ed2f4e44b7d.jpg.w960.jpg\" style=\"height:320px; width:320px\" /></strong><br /><br />Go beyond stock speeds. ROG G701 is equipped with 64GB of 2800MHz DDR4 Memory for superior application performance. It\u2019s paired with a next generation NVMe PCIe SSD, that supports theoretical speeds 4-times greater than SATA-based drives. This results in near-instant application launches and fast boot times.&nbsp;<hr /><br /><strong>120HZ WIDEVIEW PANEL WITH G-SYNC SUPPORT<br /><br /><img alt=\"\" src=\"https://smedia.webcollage.net/rwvfp/wc/cp/23137514/module/asus/_cp/products/1485198472421/tab-6f36d4a4-a37a-4a56-81e4-acfef128bc74/e1a37c7e-cc94-40a2-96a3-2587bfe3c645.jpg.w960.jpg\" style=\"height:320px; width:320px\" /></strong><br /><br />ROG G701 features a super-fast 120Hz panel that supports NVIDIA\u00AE G-SYNC\u2122 technology for fast-paced games. G-SYNC synchronizes the display's refresh rate to the GeForce graphics card to ensure super-smooth visuals. G-SYNC minimizes frame-rate stutter, and eliminates input lag and visual tearing. It delivers the smoothest and fastest gaming graphics \u2014 all without affecting system performance. See everything with accurate detail with the 178\u00B0 Viewing Angle IPS-Type panel.<hr /><br /><strong>VR READY<br /><br /><img alt=\"\" src=\"https://smedia.webcollage.net/rwvfp/wc/cp/23137514/module/asus/_cp/products/1485198472421/tab-6f36d4a4-a37a-4a56-81e4-acfef128bc74/b3387c6e-9b96-4557-bd5a-961e3c62978e.jpg.w960.jpg\" style=\"height:320px; width:320px\" /></strong><br /><br />GeForce GTX 10-series graphics cards are powered by Pascal to deliver up to 3x the performance of previous-generation graphics cards, plus innovative new gaming technologies and breakthrough VR experiences.&nbsp;<br /><br />Enjoy immersive virtual reality that is smooth, low-latency, and stutter-free with the G701VI OC Edition.<hr /><br /><strong>ANTI-GHOSTING KEYBOARD WITH 30-KEY ROLLOVER<br /><br /><img alt=\"\" src=\"https://smedia.webcollage.net/rwvfp/wc/cp/23137514/module/asus/_cp/products/1485198472421/tab-6f36d4a4-a37a-4a56-81e4-acfef128bc74/292a14db-1d74-4cf9-96b5-019fd6101758.jpg.w960.jpg\" style=\"height:320px; width:320px\" /></strong><br /><br />ROG G701 has an anti-ghosting keyboard with 30-key rollover technology so up to 30 keystrokes can be instantaneously and correctly logged, even when you hit several of them at once.&nbsp;<br /><br />Each key is ergonomically-designed to ensure solid and responsive keystrokes when typing or entering commands \u2013 making it easy for you to dominate the battlefield. And with a new Record key and more macro keys at your disposal, everything you need is at your fingertips.<hr /><br /><strong>ESS SABRE HEADPHONE DAC AND AMPLIFIER<br /><br /><img alt=\"\" src=\"https://smedia.webcollage.net/rwvfp/wc/cp/23137514/module/asus/_cp/products/1485198472421/tab-6f36d4a4-a37a-4a56-81e4-acfef128bc74/66af7726-defd-4384-90b4-ac9ad4a3ce9a.jpg.w960.jpg\" style=\"height:320px; width:320px\" /></strong><br /><br />ROG G701 features an ESS Sabre headphone DAC and amplifier to give you a sample rate eight times greater than CD-quality audio. The ESS Sabre headphone DAC improves sound quality to provide you with a high dynamic range (DNR) and less noise for rich 384Hz/32bit sound output. In-game audio sounds richer, with greater detail and less distortion, even when you're using a headset.<hr /><br /><strong>STREAMING FRIENDLY FEATURES<br /><br /><img alt=\"\" src=\"https://smedia.webcollage.net/rwvfp/wc/cp/23137514/module/asus/_cp/products/1485198472421/tab-6f36d4a4-a37a-4a56-81e4-acfef128bc74/fd5da23f-88c8-48ca-81e2-4101b6b77733.jpg.w960.jpg\" style=\"height:320px; width:320px\" /></strong><br /><br />ROG G701 is designed to for optimal streaming performance while playing games due to its high end Core i7 Processor and GTX 1080 graphics. ROG G701 comes with a lifetime XSplit license. It has a dedicated recording key that lets you launch XSplit Gamecaster with just one click so you can record or broadcast your gaming session. XSplit Gamecaster allows you to easily stream or record gameplay via a convenient in-game overlay. Make in-game annotations to highlight what's happening onscreen. You can even interact with friends and fans by broadcasting on Twitch.<hr /><br /><strong>COOLING WITHOUT COMPROMISE<br /><br /><img alt=\"\" src=\"https://smedia.webcollage.net/rwvfp/wc/cp/23137514/module/asus/_cp/products/1485198472421/tab-6f36d4a4-a37a-4a56-81e4-acfef128bc74/ece89df9-2ce3-4e8d-adff-cde0f0aba3bc.png.w960.png\" style=\"height:321px; width:320px\" /></strong><br /><br />ROG G701VI has a unique thermal design that directs dust into a dust-release tunnel to keep it away from internal components. This prolongs the component lifespan and enhances overall stability of the laptop by preventing dust from clogging the radiator and reducing cooling effectiveness. The G701VI has dedicated cooling modules for the CPU and GPU to effectively cool each component. In the cooling process, hot exhaust is efficiently managed and expelled through rear vents, directing heat away in order to provide a more comfortable gaming session.<hr /><br /><strong>ROG GAMING CENTER<br /><br /><img alt=\"\" src=\"https://smedia.webcollage.net/rwvfp/wc/cp/23137514/module/asus/_cp/products/1485198472421/tab-6f36d4a4-a37a-4a56-81e4-acfef128bc74/4b725c85-05ac-4b0d-b606-7935b98b734f.png.w960.png\" style=\"height:321px; width:320px\" /></strong><br /><br />The new ROG Gaming Center improves your gaming experience. This integrated control center provides access to Turbo Gear's three overclocking modes (Standard, Extreme and Manual) for quick and easy access to extreme performance levels. Extreme mode goes all in - letting you experience everything ROG G701VI has to offer with just one click. You also have the option to overclock manually, so you can unlock your own personal overclocking achievements!<hr /><br /><strong>ASUS ACCIDENTAL DAMAGE PROTECTION (ADP)</strong><hr /><strong>YOUR ALWAYS ON-CALL PC MEDICS</strong><br />One-year Accidental Damage Protection<br /><br />It's a fact -- accidents happen to all of us. ASUS ADP program1 is created to bring you peace of mind and help protect your devices against damages such as: liquid spills, electrical surges, and drops.<br /><br />*ASUS ADP program applies only to select ASUS branded notebook and tablet products sold within the United States and Canada from select Authorized ASUS Resellers. Products must be purchased in brand new factory sealed condition and not of refurbished or open-box condition. Units sold and purchased outside of the United States and Canada are not eligible.For more details and a list of excluded Resellers, please visit http://adp.asus.com.<br /><br /><strong>WHAT'S IN THE BOX</strong><hr /><ul><li>ASUS ROG G701VI Laptop</li><li>AC Adapter</li><li>User Manual</li><li>Warranty Card</li></ul><br /><strong>ROG 10TH</strong><hr /><img alt=\"\" src=\"https://smedia.webcollage.net/rwvfp/wc/cp/23137514/module/asus/_cp/products/1485198472421/tab-f7be1a10-2dbb-474c-ac59-9482c7ebbcf7/a5df2b68-aade-4c77-b750-d8ea0fb3537e.png.w960.png\" style=\"height:221px; width:234px\" /><br />Now in its 10th year, ROG celebrates the ever-evolving collaboration between world-class R&amp;D, insatiable enthusiasts and devoted gamers needed to embrace (and tame) the bleeding edge and is ready to keep outrunning technology for ten more.",
                RetailPrice = 3499m,
                SpecialPrice = 2624.99m,
                SpecialPriceStartDate = DateTime.Now,
                SpecialPriceEndDate = DateTime.Now.AddDays(30),
                StockQuantity = 1000,
                NotifyForQuantityBelow = 1,
                MinimumCartQuantity = 1,
                MaximumCartQuantity = 1000,
                SeoUrl = "ROG-G701VI-7th-Gen-Intel-Core",
                Published = true,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Categories =
                    [
                        new ProductCategoryMapping { ProductId = _RogG7, CategoryId = laptop }
                    ],
                Manufacturers =
                    [
                        new ProductManufacturerMapping { ProductId = _RogG7, ManufacturerId = asus }
                    ],
                Images =
                    [
                        new ProductImageMapping { ProductId = _RogG7, ImageId = i_RogG7Front, SortOrder = 0, Position = 0 },
                        new ProductImageMapping { ProductId = _RogG7, ImageId = i_RogG7Back, SortOrder = 0, Position = 1 }
                    ],
                Specifications =
                    [
                        new() { ProductId = _RogG7, SpecificationId = processor, Value = "Intel® Core™ i7 7820HK Processor", SortOrder = 0, Position = 0 },
                        new() { ProductId = _RogG7, SpecificationId = operating, Value = "Windows 10 Home", SortOrder = 0, Position = 1 },
                        new() { ProductId = _RogG7, SpecificationId = chipset, Value = "Intel® CM238 Express Chipset", SortOrder = 0, Position = 2 },
                        new() { ProductId = _RogG7, SpecificationId = memory, Value = "DDR4 2400MHz SDRAM, up to 64 GB SDRAM ( Overclocking to 2800MHz Supported )", SortOrder = 0, Position = 3 },
                        new() { ProductId = _RogG7, SpecificationId = display, Value = "17.3&quot; (16:9) LED backlit FHD (1920x1080) 120Hz Anti-Glare Panel with 72% NTSC&amp;nbsp;&lt;br /&gt;17.3&quot; (16:9) LED backlit UHD (3840x2160) 60Hz Anti-Glare Panel with 100% NTSC&amp;nbsp;&lt;br /&gt;With WideView Technology", SortOrder = 0, Position = 4 },
                        new() { ProductId = _RogG7, SpecificationId = graphic, Value = "NVIDIA GeForce GTX 1080", SortOrder = 0, Position = 5 },
                        new() { ProductId = _RogG7, SpecificationId = storage, Value = "<strong>Solid State Drives:</strong><br />256GB/512GB PCIE Gen3X4 SSD RAID 0 Support", SortOrder = 0, Position = 6 },
                        new() { ProductId = _RogG7, SpecificationId = keyboard, Value = "Chicklet keyboard with isolated Num key", SortOrder = 0, Position = 7 },
                        new() { ProductId = _RogG7, SpecificationId = webCam, Value = "HD Web Camera", SortOrder = 0, Position = 8 },
                        new() { ProductId = _RogG7, SpecificationId = networking, Value = "<strong>Wi-Fi</strong><br />Integrated 802.11 AC", SortOrder = 0, Position = 9 },
                        new() { ProductId = _RogG7, SpecificationId = _interface, Value = "1 x Microphone-in jack<br />1 x Headphone-out jack&nbsp;<br />2 x Type A USB3.0 (USB3.1 GEN1)&nbsp;<br />3 x Type A USB3.0 (USB3.1 GEN1)&nbsp;<br />1 x HDMI&nbsp;<br />1 x mini Display Port&nbsp;", SortOrder = 0, Position = 10 },
                        new() { ProductId = _RogG7, SpecificationId = battery, Value = "6 Cells 93 Whrs Battery", SortOrder = 0, Position = 11 },
                        new() { ProductId = _RogG7, SpecificationId = dimensions, Value = "429 x 309 x 44 mm (WxDxH)", SortOrder = 0, Position = 12 },
                        new() { ProductId = _RogG7, SpecificationId = weight, Value = "with Battery", SortOrder = 0, Position = 13 },
                        new() { ProductId = _RogG7, SpecificationId = vr, Value = "VR Ready", SortOrder = 0, Position = 14 },
                        new() { ProductId = _RogG7, SpecificationId = gamingSeries, Value = "G Series", SortOrder = 0, Position = 15 }
                    ]
            };
            _context.Products.Add(product);
            _context.SaveChanges();

            var product2 = new Product // acer predator gx
            {
                Id = _AcerPredatorGx,
                Name = "Acer Predator GX-792-77BL 17.3\" 4K/UHD Intel Core i7 7th Gen 7820HK (2.90 GHz) NVIDIA GeForce GTX 1080 32 GB Memory 512 GB SSD 1 TB HDD Windows 10 Home 64-Bit Gaming Laptop",
                Description = "<strong>Immense Potential</strong><hr />The potential of this device is immense. It sports the latest 7th Gen Intel\u00AE&nbsp;Core\u2122i7 processor and NVIDIA\u00AEGeForce\u2122&nbsp;GTX 1080 graphics1.<br /><br /><br /><strong>Custom-Engineered Cooling</strong><hr />Unlock the potential of Predator hardware with a custom-engineered triple-fan cooling system with a front air intake design.<br /><br /><br /><strong>Front</strong><hr /><p><img alt=\"\" src=\"https://static.acer.com/up/Resource/Acer/Predator_Minisite/Product_Series/Predator_17X/Benefit/20160407/Benefit_F-B_Predator_17X_front.png\" style=\"height:222px; width:320px\" /><br />Glass-fiber construction with edgy triangle element and powerful color accents.<br /><br /><br /><strong>Back</strong></p><hr /><p><strong><img alt=\"\" src=\"https://static.acer.com/up/Resource/Acer/Predator_Minisite/Product_Series/Predator_17X/Benefit/20160407/Benefit_F-B_Predator_17X_back.png\" style=\"height:222px; width:320px\" /></strong><br />A full complement of port connections.<br /><br /><br /><strong>PredatorSense</strong></p><hr /><p>Control and customize your gaming experience from one place with PredatorSense, from the RGB backlit keyboard to overclocking.<br /><br /><br /><strong>Faster Everything</strong></p><hr /><p>Feed your need for speed with 3 SATA in RAID 0 or PCIe NVMe SSD. Enjoy faster data and charging with USB-C Thunderbolt\u2122&nbsp;3 and optimize your precious bandwidth with Killer DoubleShot Pro\u2122.</p>",
                RetailPrice = 2699m,
                StockQuantity = 1000,
                NotifyForQuantityBelow = 1,
                MinimumCartQuantity = 1,
                MaximumCartQuantity = 1000,
                SeoUrl = "Acer-Predator-GX-792-77BL-Intel-Core-i7-7th-Gen",
                Published = true,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Categories =
                    [
                        new ProductCategoryMapping { ProductId = _AcerPredatorGx, CategoryId = laptop }
                    ],
                Manufacturers =
                    [
                        new ProductManufacturerMapping { ProductId = _AcerPredatorGx, ManufacturerId = acer }
                    ],
                Images =
                    [
                        new ProductImageMapping { ProductId = _AcerPredatorGx, ImageId = i_Predator17XFront, SortOrder = 0, Position = 0 },
                        new ProductImageMapping { ProductId = _AcerPredatorGx, ImageId = i_Predator17XBack, SortOrder = 0, Position = 1 }
                    ],
                Specifications =
                    [
                        new() { ProductId = _AcerPredatorGx, SpecificationId = processor, Value = "Intel® Core™ i7 7820HK Processor", SortOrder = 0, Position = 0 },
                        new() { ProductId = _AcerPredatorGx, SpecificationId = operating, Value = "Windows 10 Home", SortOrder = 0, Position = 1 },
                        new() { ProductId = _AcerPredatorGx, SpecificationId = memory, Value = "32 GB DDR4 2400MHz (16 GB x 2)", SortOrder = 0, Position = 2 },
                        new() { ProductId = _AcerPredatorGx, SpecificationId = display, Value = "17.3\" 4K/UHD<br />3840 x 2160<br />LED-backlit IPS display with NVIDIA G-SYNC technology<br />Wide viewing angle", SortOrder = 0, Position = 3 },
                        new() { ProductId = _AcerPredatorGx, SpecificationId = graphic, Value = "NVIDIA GeForce GTX 1080", SortOrder = 0, Position = 4 },
                        new() { ProductId = _AcerPredatorGx, SpecificationId = storage, Value = "1 TB HDD + 512 GB SSD", SortOrder = 0, Position = 5 },
                        new() { ProductId = _AcerPredatorGx, SpecificationId = webCam, Value = "HD Webcam (1280 x 720)", SortOrder = 0, Position = 6 },
                        new() { ProductId = _AcerPredatorGx, SpecificationId = networking, Value = "Killer Double Shot Pro Wireless-AC 1535 802.11ac WiFi featuring 2x2 MU-MIMO technology (Dual-Band 2.4GHz and 5GHz)", SortOrder = 0, Position = 7 },
                        new() { ProductId = _AcerPredatorGx, SpecificationId = _interface, Value = "4 x USB 3.0 (One with Power-off Charging)<br />1 x Thunderbolt 3 (Full USB 3.1 Type C)<br />1 x DisplayPort<br />1 x HDMI 2.0<br />1 x Headphone / Speaker / Line-out Jack", SortOrder = 0, Position = 8 },
                        new() { ProductId = _AcerPredatorGx, SpecificationId = battery, Value = "8-cell Li-ion Battery (6000 mAh)", SortOrder = 0, Position = 9 },
                        new() { ProductId = _AcerPredatorGx, SpecificationId = dimensions, Value = "16.65\" x 12.66\" x 1.77\" (WxDxH)", SortOrder = 0, Position = 10 },
                        new() { ProductId = _AcerPredatorGx, SpecificationId = weight, Value = "10.03 lbs.", SortOrder = 0, Position = 11 }
                    ]
            };
            _context.Products.Add(product2);
            _context.SaveChanges();

            var product3 = new Product // asus gtx 1080 ti founder
            {
                Id = _AsusGtx1080tiFounder,
                Name = "ASUS GeForce GTX 1080 TI 11GB GDDR5X Founders Edition",
                Description = "<ul><li>Fastest gaming GPU with 3584 NVIDIA\u00AE CUDA\u00AE cores and massive 11GB frame buffer, delivering 35% faster performance than the GeForce GTX 1080</li><li>Get up to 3X the performance and power efficiency of previous generation GPUs.</li><li>Ultra-fast FinFET and high-speed GDDR5X technologies, plus support for DirectX\u2122 12 features.</li><li>NVIDIA GameWorks\u2122 for a more interactive and cinematic experience, as well as incredibly smooth gameplay.</li><li>ASUS GPU Tweak II with XSplit Gamecaster for intuitive performance tweaking and instant gameplay streaming.</li></ul><br /><br /><strong>Ultimate ASUS GeForce GTX 1080 Ti</strong><hr /><br /><img alt=\"\" src=\"https://www.asus.com/websites/global/products/jkXGrxp17lHUXBxV/img/GTX1080-8G_3D_500.png\" style=\"height:210px; width:300px\" /><br /><br />ASUS GeForce\u00AE GTX 1080 Ti Founders Edition is the most powerful and efficient hardware that is up to 35% faster than the GeForce GTX 1080, and is even faster in games than the NVIDIA TITAN X. The card is packed with extreme gaming horsepower, next-gen 11 Gbps GDDR5X memory, and a massive 11GB frame buffer. It is bundled with a free 1-year premium license of customized ASUS GPU Tweak II and XSplit Gamecaster for intuitive performance tweaking and instant gameplay streaming.<br /><br /><br /><strong>Ultimate GeForce</strong><hr /><img alt=\"\" src=\"http://cdn.wccftech.com/wp-content/uploads/2012/12/GeForce-logo.jpg\" style=\"height:88px; width:200px\" /><br /><br />The GeForce\u00AE GTX 1080 Ti is NVIDIA\u2019s new flagship gaming GPU, based on the NVIDIA Pascal\u2122 architecture. The latest addition to the ultimate gaming platform, this card is packed with extreme gaming horsepower, next-gen 11 Gbps GDDR5X memory, and a massive 11 GB frame buffer. #GameReady.<br /><br /><br /><strong>Performance</strong><hr />The GeForce\u00AE GTX 1080 Ti is the world\u2019s fastest gaming GPU. 3584 NVIDIA\u00AE CUDA\u00AE cores and a massive 11 GB frame buffer deliver 35% faster performance than the GeForce GTX 1080.<br /><br /><br /><strong>NVIDIA Pascal</strong><hr />GeForce\u00AE GTX 10-Series graphics cards are powered by Pascal to deliver up to 3X the performance of previous-generation graphics cards, plus breakthrough gaming technologies and VR experiences.<br /><br /><br /><strong>VR Ready</strong><hr /><img alt=\"\" src=\"http://images.nvidia.com/content/virtual-reality/vr-ready-program/geforce-gtx-virtual-reality.jpg\" style=\"height:96px; width:400px\" /><br />Discover next-generation VR performance, the lowest latency, and plug-and-play compatibility with leading headsets\u2014driven by NVIDIA VRWorks\u2122 technologies. VR audio, physics, and haptics let you hear and feel every moment.<br /><br /><br /><strong>Innovative Design</strong><hr /><img alt=\"\" src=\"https://www.msi.com/asset/resize/image/global/product/product_10_20170302172320_58b7e488df2c8.png62405b38c58fe0f07fcef2367d8a9ba1/600.png\" style=\"height:240px; width:300px\" /><br />Unprecedented gaming horsepower. Exceptional craftsmanship. A 7-phase dualFET power supply. All cooled by a radial fan with an advanced vapor chamber designed to for consistent performance in even the most thermally challenging environments. This is the forward-thinking innovation that makes the GeForce\u00AE GTX 1080 Ti the Ultimate GeForce.",
                RetailPrice = 829.99m,
                StockQuantity = 1000,
                NotifyForQuantityBelow = 1,
                MinimumCartQuantity = 1,
                MaximumCartQuantity = 1000,
                SeoUrl = "ASUS-GeForce-GTX-1080-TI-11GB-GDDR5X-Founders-Edition",
                Published = true,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Categories =
                    [
                        new ProductCategoryMapping { ProductId = _AsusGtx1080tiFounder, CategoryId = videocard }
                    ],
                Manufacturers =
                    [
                        new ProductManufacturerMapping { ProductId = _AsusGtx1080tiFounder, ManufacturerId = asus }
                    ],
                Images =
                    [
                        new ProductImageMapping { ProductId = _AsusGtx1080tiFounder, ImageId = i_AsusGtx1080tiFounder, SortOrder = 0, Position = 0 },
                        new ProductImageMapping { ProductId = _AsusGtx1080tiFounder, ImageId = i_AsusGtx1080tiFounder2, SortOrder = 0, Position = 1 }
                    ],
                Specifications =
                    [
                        new() { ProductId = _AsusGtx1080tiFounder, SpecificationId = graphicsEngine, Value = "NVIDIA GeForce GTX 1080 TI", SortOrder = 0, Position = 0 },
                        new() { ProductId = _AsusGtx1080tiFounder, SpecificationId = videoMemory, Value = "GDDR5X 11GB", SortOrder = 0, Position = 1 },
                        new() { ProductId = _AsusGtx1080tiFounder, SpecificationId = engineClock, Value = "GPU Boost Clock : 1582 MHz<br />GPU Base Clock : 1480 MHz", SortOrder = 0, Position = 2 },
                        new() { ProductId = _AsusGtx1080tiFounder, SpecificationId = cudaCore, Value = "3584", SortOrder = 0, Position = 3 },
                        new() { ProductId = _AsusGtx1080tiFounder, SpecificationId = memoryClock, Value = "11010 MHz", SortOrder = 0, Position = 4 },
                        new() { ProductId = _AsusGtx1080tiFounder, SpecificationId = memoryInterface, Value = "352-bit", SortOrder = 0, Position = 5 },
                        new() { ProductId = _AsusGtx1080tiFounder, SpecificationId = resolution, Value = "Digital Max Resolution: 7680 x 4320", SortOrder = 0, Position = 6 },
                        new() { ProductId = _AsusGtx1080tiFounder, SpecificationId = _interface, Value = "HDMI Output : Yes x 1 (Native) (HDMI 2.0)<br />Display Port : Yes x 3 (Native) (Regular DP)<br />HDCP Support : Yes", SortOrder = 0, Position = 7 },
                        new() { ProductId = _AsusGtx1080tiFounder, SpecificationId = powerConnectors, Value = "1 x 6-pin, 1 x 8-pin", SortOrder = 0, Position = 8 },
                        new() { ProductId = _AsusGtx1080tiFounder, SpecificationId = accessories, Value = "1 x DP-DVI Dongle", SortOrder = 0, Position = 9 },
                        new() { ProductId = _AsusGtx1080tiFounder, SpecificationId = software, Value = "ASUS GPU Tweak II & Driver", SortOrder = 0, Position = 10 },
                        new() { ProductId = _AsusGtx1080tiFounder, SpecificationId = dimensions, Value = "10.5 \" x 4.376 \" x 1.5 \" Inch<br />26.67 x 11.12 x3.81 Centimeter", SortOrder = 0, Position = 11 }
                    ]
            };
            _context.Products.Add(product3);
            _context.SaveChanges();

            var product4 = new Product // asus gtx 1070 strix
            {
                Id = _AsusGtx1070Strix,
                Name = "ASUS ROG GeForce GTX 1070 STRIX 8GB 256-Bit GDDR5",
                Description = "<strong>ROG Strix GeForce\u00AE GTX 1070 OC edition 8GB GDDR5 with Aura Sync RGB for best VR &amp; 4K gaming</strong><hr /><ul><li>1860 MHz boost clock in OC mode for outstanding performance and gaming experience.</li><li>DirectCU III with Patented Wing-Blade Fans for 30% cooler and 3X quieter performance.</li><li>ASUS FanConnect features 4-pin GPU-controlled headers connected to system fans for optimal thermal performance.</li><li>Industry Only Auto-Extreme Technology with Super Alloy Power II delivers premium quality and best reliability.</li><li>Aura RGB Lighting to express personalized gaming style.</li><li>VR-friendly HDMI ports for immersive virtual reality experiences.</li><li>GPU Tweak II with Xsplit Gamecaster provides intuitive performance tweaking and lets you stream your gameplay instantly.</li><li>NVIDIA ANSEL for a revolutionary new way to capture in-game screenshots.</li><li>NVIDIA GameWorks\u2122 provides an interactive and cinematic experience, as well as incredibly smooth gameplay.</li></ul><br /><strong>OUTSHINE THE COMPETITION</strong><hr />ROG Strix GeForce\u00AE GTX 1070 gaming graphics cards are packed with exclusive ASUS technologies, including DirectCU III Technology with Patented Wing-Blade Fans for 30% cooler and 3X quieter performance, and Industry-only Auto-Extreme Technology for premium quality and the best reliability. Aura RGB Lighting enables a gaming system personalization and VR-friendly HDMI ports let gamers easily enjoy immersive virtual reality experiences. ROG Strix GeForce\u00AE GTX 1070 also has GPU Tweak II with XSplit Gamecaster that provides intuitive performance tweaking and instant gameplay streaming.<br /><br /><br /><img alt=\"\" src=\"https://www.asus.com/Graphics-Cards/ROG-STRIX-GTX1070-O8G-GAMING/overview/websites/global/products/IkF5VLiS13T4hUIG/img/overview.jpg\" style=\"height:300px; width:700px\" /><br /><br /><br /><strong>LEVEL UP PERFORMANCE</strong><hr />DOOM\u2122 Resolution: 3840 x 2160 Setting: Ultra<br /><img alt=\"\" src=\"https://www.asus.com/Graphics-Cards/ROG-STRIX-GTX1070-O8G-GAMING/overview/websites/global/products/IkF5VLiS13T4hUIG/img/performance-chart1.png\" style=\"height:125px; width:300px\" /><br /><br />Ashes of the Singularity\u2122 Resolution: 2560 x 1440 Setting: Crazy<br /><img alt=\"\" src=\"https://www.asus.com/Graphics-Cards/ROG-STRIX-GTX1070-O8G-GAMING/overview/websites/global/products/IkF5VLiS13T4hUIG/img/performance-chart2.png\" style=\"height:125px; width:300px\" /><br /><br /><br /><strong>GAME COOL AND PLAY SILENT</strong><hr /><ul><li><strong>DirectCU III Technology&nbsp;with Direct-GPU Contact Heatpipes</strong><ul><li>30% Cooler and 3X Quieter Performance</li><li>Exclusive DirectCU III cooling technology features direct-GPU contact heatpipes that transports more heat away from the GPU and outperform reference designs, achieving up to 30% cooler gaming performance.</li></ul></li></ul>\u00A0<ul><li><strong>Patented Triple Wing-Blade 0dB Fans</strong><ul><li>Max Air Flow with 105% More Air Pressure</li><li>DirectCU III features triple 0dB fans engineered with a patented wing-blade design that delivers maximum air flow and improved 105% static pressure over the heat sink, while operating at 3X quieter volumes than reference cards. The 0dB fans also let you enjoy games in complete silence and make DirectCU III the coolest and quietest graphics card in the market.</li></ul></li></ul>\u00A0<ul><li><strong>ASUS FanConnect</strong><ul><li>Targeted Supplemental Cooling</li><li>When gaming, GPU temperatures are often higher than CPU temps. However, chassis fans usually reference CPU temperatures only, which results in inefficient cooling of the system. For optimal thermal performance, ROG Strix graphics cards feature two 4-pin GPU-controlled headers that can be connected to system fans for targeted cooling.</li></ul></li></ul>",
                RetailPrice = 444.99m,
                StockQuantity = 1000,
                NotifyForQuantityBelow = 1,
                MinimumCartQuantity = 1,
                MaximumCartQuantity = 1000,
                SeoUrl = "ASUS-ROG-GeForce-GTX-1070-STRIX-8GB-256-Bit-GDDR5",
                Published = true,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Categories =
                    [
                        new ProductCategoryMapping { ProductId = _AsusGtx1070Strix, CategoryId = videocard }
                    ],
                Manufacturers =
                    [
                        new ProductManufacturerMapping { ProductId = _AsusGtx1070Strix, ManufacturerId = asus }
                    ],
                Images =
                    [
                        new ProductImageMapping { ProductId = _AsusGtx1070Strix, ImageId = i_AsusGgtx1070Strix, SortOrder = 0, Position = 0 }
                    ],
                Specifications =
                    [
                        new() { ProductId = _AsusGtx1070Strix, SpecificationId = graphicsEngine, Value = "NVIDIA GeForce GTX 1070", SortOrder = 0, Position = 0 },
                        new() { ProductId = _AsusGtx1070Strix, SpecificationId = videoMemory, Value = "GDDR5 8GB", SortOrder = 0, Position = 1 },
                        new() { ProductId = _AsusGtx1070Strix, SpecificationId = engineClock, Value = "OC Mode - GPU Boost Clock : 1860 MHz , GPU Base Clock : 1657 MHz<br />Gaming Mode (Default) - GPU Boost Clock : 1835 MHz , GPU Base Clock : 1632 MHz<br />*Retail goods are with default Gaming Mode, OC Mode can be adjusted with one click on GPU Tweak II", SortOrder = 0, Position = 2 },
                        new() { ProductId = _AsusGtx1070Strix, SpecificationId = cudaCore, Value = "1920", SortOrder = 0, Position = 3 },
                        new() { ProductId = _AsusGtx1070Strix, SpecificationId = memoryClock, Value = "8008 MHz", SortOrder = 0, Position = 4 },
                        new() { ProductId = _AsusGtx1070Strix, SpecificationId = memoryInterface, Value = "256-bit", SortOrder = 0, Position = 5 },
                        new() { ProductId = _AsusGtx1070Strix, SpecificationId = resolution, Value = "Digital Max Resolution:7680 x 4320", SortOrder = 0, Position = 6 },
                        new() { ProductId = _AsusGtx1070Strix, SpecificationId = _interface, Value = "DVI Output : Yes x 1 (Native) (DVI-D)<br />HDMI Output : Yes x 2 (Native) (HDMI 2.0)<br />Display Port : Yes x 2 (Native) (Regular DP)<br />HDCP Support : Yes", SortOrder = 0, Position = 7 },
                        new() { ProductId = _AsusGtx1070Strix, SpecificationId = powerConnectors, Value = "1 x 8-pin", SortOrder = 0, Position = 8 },
                        new() { ProductId = _AsusGtx1070Strix, SpecificationId = accessories, Value = "2 x ROG Cable Ties", SortOrder = 0, Position = 9 },
                        new() { ProductId = _AsusGtx1070Strix, SpecificationId = software, Value = "ASUS GPU Tweak II & Driver", SortOrder = 0, Position = 10 },
                        new() { ProductId = _AsusGtx1070Strix, SpecificationId = dimensions, Value = "11.73\" x 5.28\" x 1.57\" Inch<br />29.8 x 13.4 x4 Centimeter", SortOrder = 0, Position = 11 }
                    ]
            };
            _context.Products.Add(product4);
            _context.SaveChanges();

            var product5 = new Product // rog strix rx480 O8G gaming
            {
                Id = _RogStrixRx480O8G,
                Name = "ROG STRIX RX480 O8G GAMING",
                Description = "<strong>ASUS ROG Strix RX 480 outshines the competition with Aura RGB Lighting</strong><hr /><ul><li>1330MHz boost clock in OC mode for outstanding performance and gaming experience</li><li>DirectCU III with Patented Wing-Blade Fans delivers 30% cooler and 3X quieter performance.</li><li>ASUS FanConnect features 4-pin GPU-controlled headers connected to system fans for optimal thermal performance.</li><li>Industry Only Auto-Extreme Technology with Super Alloy Power II delivers premium quality and best reliability.</li><li>Aura RGB Lighting to express personalized gaming style.</li><li>VR-friendly HDMI Ports for immersive virtual reality experiences.</li><li>GPU Tweak II with XSplit Gamecaster provides intuitive performance tweaking and lets you stream your gameplay instantly.</li></ul><br /><strong>OUTSHINE THE COMPETITION</strong><hr />ROG Strix Radeon RX 480 gaming graphics cards are packed with exclusive ASUS technologies, including DirectCU III Technology with Patented Wing-Blade Fans for 30% cooler and 3X quieter performance, and Industry-only Auto-Extreme Technology for premium quality and the best reliability. Aura RGB Lighting enables a gaming system personalization and VR-friendly HDMI ports let gamers easily enjoy immersive virtual reality experiences. ROG Strix Radeon RX 480 also has GPU Tweak II with XSplit Gamecaster that provides intuitive performance tweaking and instant gameplay streaming.<br /><br /><br /><img alt=\"\" src=\"https://www.asus.com/Graphics-Cards/ROG-STRIX-GTX1070-O8G-GAMING/overview/websites/global/products/IkF5VLiS13T4hUIG/img/overview.jpg\" style=\"height:300px; width:700px\" /><br /><br /><br /><strong>LEVEL UP PERFORMANCE</strong><hr />DOOM\u2122 Resolution: 3840 x 2160 Setting: Ultra<br /><img alt=\"\" src=\"https://www.asus.com/ROG-Republic-Of-Gamers/ROG-STRIX-RX480-O8G-GAMING/overview/websites/global/products/FEFh1zLUB6OEcm1o/img/performance-chart1.png\" style=\"height:202px; width:485px\" /><br /><br />Hitman\u2122 Resolution: 2560 x 1440 Setting: Ultra<br /><img alt=\"\" src=\"https://www.asus.com/ROG-Republic-Of-Gamers/ROG-STRIX-RX480-O8G-GAMING/overview/websites/global/products/FEFh1zLUB6OEcm1o/img/performance-chart2.png\" style=\"height:202px; width:485px\" /><br /><br /><br /><strong>GAME COOL AND PLAY SILENT</strong><hr /><ul><li><strong>DirectCU III Technology&nbsp;with Direct-GPU Contact Heatpipes</strong><ul><li>30% Cooler and 3X Quieter Performance</li><li>Exclusive DirectCU III cooling technology features direct-GPU contact heatpipes that transports more heat away from the GPU and outperform reference designs, achieving up to 30% cooler gaming performance.</li></ul></li></ul>\u00A0<ul><li><strong>Patented Triple Wing-Blade 0dB Fans</strong><ul><li>Max Air Flow with 105% More Air Pressure</li><li>DirectCU III features triple 0dB fans engineered with a patented wing-blade design that delivers maximum air flow and improved 105% static pressure over the heat sink, while operating at 3X quieter volumes than reference cards. The 0dB fans also let you enjoy games in complete silence and make DirectCU III the coolest and quietest graphics card in the market.</li></ul></li></ul>\u00A0<ul><li><strong>ASUS FanConnect</strong><ul><li>Targeted Supplemental Cooling</li><li>When gaming, GPU temperatures are often higher than CPU temps. However, chassis fans usually reference CPU temperatures only, which results in inefficient cooling of the system. For optimal thermal performance, ROG Strix graphics cards feature two 4-pin GPU-controlled headers that can be connected to system fans for targeted cooling.</li></ul></li></ul>",
                RetailPrice = 264.99m,
                SpecialPrice = 214.99m,
                SpecialPriceStartDate = DateTime.Now,
                SpecialPriceEndDate = DateTime.Now.AddDays(30),
                StockQuantity = 1000,
                NotifyForQuantityBelow = 1,
                MinimumCartQuantity = 1,
                MaximumCartQuantity = 1000,
                SeoUrl = "ROG-STRIX-RX480-O8G-GAMING",
                Published = true,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Categories =
                    [
                        new ProductCategoryMapping { ProductId = _RogStrixRx480O8G, CategoryId = videocard }
                    ],
                Manufacturers =
                    [
                        new ProductManufacturerMapping { ProductId = _RogStrixRx480O8G, ManufacturerId = asus }
                    ],
                Images =
                    [
                        new ProductImageMapping { ProductId = _RogStrixRx480O8G, ImageId = i_RogStrixRx480O8G, SortOrder = 0, Position = 0 }
                    ],
                Specifications =
                    [
                        new() { ProductId = _RogStrixRx480O8G, SpecificationId = graphicsEngine, Value = "AMD Radeon RX 480", SortOrder = 0, Position = 0 },
                        new() { ProductId = _RogStrixRx480O8G, SpecificationId = videoMemory, Value = "GDDR5 8GB", SortOrder = 0, Position = 1 },
                        new() { ProductId = _RogStrixRx480O8G, SpecificationId = engineClock, Value = "1330 MHz (OC Mode)<br />1310 MHz (Gaming Mode)<br />*Retail goods are with default Gaming Mode, OC Mode can be adjusted with one click on GPU Tweak II", SortOrder = 0, Position = 2 },
                        new() { ProductId = _RogStrixRx480O8G, SpecificationId = memoryClock, Value = "8000 MHz", SortOrder = 0, Position = 3 },
                        new() { ProductId = _RogStrixRx480O8G, SpecificationId = memoryInterface, Value = "256-bit", SortOrder = 0, Position = 4 },
                        new() { ProductId = _RogStrixRx480O8G, SpecificationId = resolution, Value = "Digital Max Resolution:7680 x 4320", SortOrder = 0, Position = 5 },
                        new() { ProductId = _RogStrixRx480O8G, SpecificationId = _interface, Value = "DVI Output : Yes x 1 (Native) (DVI-D)<br />HDMI Output : Yes x 2 (Native) (HDMI 2.0)<br />Display Port : Yes x 2 (Native) (Regular DP)<br />HDCP Support : Yes", SortOrder = 0, Position = 6 },
                        new() { ProductId = _RogStrixRx480O8G, SpecificationId = powerConnectors, Value = "1 x 8-pin", SortOrder = 0, Position = 7 },
                        new() { ProductId = _RogStrixRx480O8G, SpecificationId = accessories, Value = "2 x ROG Cable Ties", SortOrder = 0, Position = 8 },
                        new() { ProductId = _RogStrixRx480O8G, SpecificationId = software, Value = "ASUS GPU Tweak II & Driver<br />Aura (Graphics Card) Software", SortOrder = 0, Position = 9 },
                        new() { ProductId = _RogStrixRx480O8G, SpecificationId = dimensions, Value = "11.73\" x 5.28\" x 1.57\" Inch<br />29.8 x 13.4 x4 Centimeter", SortOrder = 0, Position = 10 }
                    ]
            };
            _context.Products.Add(product5);
            _context.SaveChanges();

            var product6 = new Product // Intel Core i7-7700K
            {
                Id = _IntelCorei77700K,
                Name = "Intel Core i7-7700K Kaby Lake Quad-Core 4.2 GHz LGA 1151 91W Desktop Processor",
                Description = "",
                RetailPrice = 349.99m,
                StockQuantity = 1000,
                NotifyForQuantityBelow = 1,
                MinimumCartQuantity = 1,
                MaximumCartQuantity = 1000,
                SeoUrl = "Intel-Core-i7-7700K-Kaby-Lake-Quad-Core-42-GHz-LGA-1151-91W-Desktop-Processor",
                Published = true,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Categories =
                    [
                        new ProductCategoryMapping { ProductId = _IntelCorei77700K, CategoryId = processors }
                    ],
                Manufacturers =
                    [
                        new ProductManufacturerMapping { ProductId = _IntelCorei77700K, ManufacturerId = intel }
                    ],
                Images =
                    [
                        new ProductImageMapping { ProductId = _IntelCorei77700K, ImageId = i_IntelCorei77700K, SortOrder = 0, Position = 0 }
                    ],
                Specifications =
                    [
                        new() { ProductId = _IntelCorei77700K, SpecificationId = brand, Value = "Intel", SortOrder = 0, Position = 0 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = processorsType, Value = "Desktop", SortOrder = 0, Position = 1 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = series, Value = "Core i7 7th Gen", SortOrder = 0, Position = 2 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = cpuSocketType, Value = "LGA 1151", SortOrder = 0, Position = 3 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = coreName, Value = "Kaby Lake", SortOrder = 0, Position = 4 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = numberOfCores, Value = "Quad-Core", SortOrder = 0, Position = 5 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = numberOfThreads, Value = "8", SortOrder = 0, Position = 6 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = operatingFrequency, Value = "4.2 GHz", SortOrder = 0, Position = 7 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = maxTurboFrequency, Value = "4.50 GHz", SortOrder = 0, Position = 8 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = l2Cache, Value = "4 x 256KB", SortOrder = 0, Position = 9 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = l3Cache, Value = "8MB", SortOrder = 0, Position = 10 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = manufacturingTech, Value = "14nm", SortOrder = 0, Position = 11 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = bit64Support, Value = "Yes", SortOrder = 0, Position = 12 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = hyperThreadingSupport, Value = "Yes", SortOrder = 0, Position = 13 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = virtualizationTechnologySupport, Value = "Yes", SortOrder = 0, Position = 14 },
                        new() { ProductId = _IntelCorei77700K, SpecificationId = thermalDesignPower, Value = "91W", SortOrder = 0, Position = 15 }
                    ]
            };
            _context.Products.Add(product6);
            _context.SaveChanges();

            var product7 = new Product // Razer Blade GTX 1060
            {
                Id = _RazerBladeGTX1060,
                Name = "The Razer Blade (GeForce GTX 1060) 14\" HD Gaming Laptop (7th Gen Intel Core i7, 16 GB RAM, 512 GB SSD)",
                Description = "<img alt=\"\" src=\"https://assets.razerzone.com/eeimages/products/26727/razer-blade-hero-laptop-v2.png\" style=\"height:383px; width:540px\" /><br /><br /><strong>POWERFUL. PORTABLE. PERFECT.</strong><br />The New Razer Blade Powered by NVIDIA\u00AE GeForce\u00AE GTX 1060<hr /><br /><strong>MORE POWERFUL. INSANELY THIN.<br /><img alt=\"\" src=\"https://assets.razerzone.com/eeimages/products/26727/razer-blade-insanely-thin-laptop.png\" style=\"height:200px; width:131px\" /></strong><br />The new 14\u201D Razer Blade strikes the perfect balance between power and portability. Experience streamlined performance with the latest 7th Gen Intel\u00AE Core\u2122 i7 Quad Core processor. Get faster, smoother and more detailed gameplay with the powerful performance of the NVIDIA\u00AE GeForce\u00AE GTX 1060 graphics. Choose from two great display options, Full HD or 4K UHD, or connect a VR headset for an even more immersive gaming experience. Get the best-in-class performance with 16GB of DDR4 dual-channel memory, PCIe-based SSD storage up to 1TB, and Killer Networking technology. All this power packed into a thin and light 0.70\u201D unibody aluminum chassis is what makes the Razer Blade the best in its class.<hr /><br /><strong>Latest 7th Gen Intel Core i7 Processor</strong><br />The new 7th Gen Intel Core i7-7700HQ processor gives the 14-inch Razer Blade 2.8GHz of quad-core processing power and Turbo Boost speeds, which automatically increases the speed of active cores \u2013 up to 3.8GHz. Work, play and create with ease and enjoy smooth, high definition 4K content like never before. With the Razer Blade\u2019s thin and light design, you\u2019d never guess it holds all that power. Only with Intel Inside\u00AE.<hr /><br /><strong>GAMING PERFECTED<br /><img alt=\"\" src=\"https://assets.razerzone.com/eeimages/products/26727/razer-blade-gaming-perfected-bg-v2.jpg\" style=\"height:270px; width:540px\" /></strong><br />The New Razer Blade is armed with the latest NVIDIA GeForce GTX 1060 GPU, powered by the ultra-fast, power-efficient NVIDIA Pascal\u2122 GPU architecture. The advanced GeForce GTX 1060 GPU is created with high-speed FinFET technology and supports DirectX 12 features. This means you can count on an amazing experience in every application\u2014including performance in high-definition and immersive VR Ready games that\u2019s up to 3X faster than with previous-generation GPUs.",
                RetailPrice = 2099.99m,
                StockQuantity = 1000,
                NotifyForQuantityBelow = 1,
                MinimumCartQuantity = 1,
                MaximumCartQuantity = 1000,
                SeoUrl = "The-Razer-Blade-GeForce-GTX-1060-14-HD-Gaming-Laptop-7th-Gen-Intel-Core-i7-16-GB-RAM-512-GB-SSD",
                Published = true,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Categories =
                    [
                        new ProductCategoryMapping { ProductId = _RazerBladeGTX1060, CategoryId = laptop }
                    ],
                Manufacturers =
                    [
                        new ProductManufacturerMapping { ProductId = _RazerBladeGTX1060, ManufacturerId = razer }
                    ],
                Images =
                    [
                        new ProductImageMapping { ProductId = _RazerBladeGTX1060, ImageId = i_TheRazerBladeFront, SortOrder = 0, Position = 0 },
                        new ProductImageMapping { ProductId = _RazerBladeGTX1060, ImageId = i_TheRazerBladeSlide, SortOrder = 0, Position = 1 }
                    ],
                Specifications =
                    [
                        new() { ProductId = _RazerBladeGTX1060, SpecificationId = processor, Value = "Intel Core i7 7th Gen 7700HQ (2.80 GHz)", SortOrder = 0, Position = 0 },
                        new() { ProductId = _RazerBladeGTX1060, SpecificationId = operating, Value = "Windows 10 Home 64-Bit", SortOrder = 0, Position = 1 },
                        new() { ProductId = _RazerBladeGTX1060, SpecificationId = memory, Value = "16 GB DDR4 2400", SortOrder = 0, Position = 2 },
                        new() { ProductId = _RazerBladeGTX1060, SpecificationId = display, Value = "14.0\" Full HD 1920 x 1080", SortOrder = 0, Position = 3 },
                        new() { ProductId = _RazerBladeGTX1060, SpecificationId = graphic, Value = "NVIDIA GeForce GTX 1060 6GB Dedicated Card", SortOrder = 0, Position = 4 },
                        new() { ProductId = _RazerBladeGTX1060, SpecificationId = storage, Value = "512 GB SSD", SortOrder = 0, Position = 5 },
                        new() { ProductId = _RazerBladeGTX1060, SpecificationId = webCam, Value = "Built-in webcam (2.0MP)", SortOrder = 0, Position = 6 },
                        new() { ProductId = _RazerBladeGTX1060, SpecificationId = networking, Value = "802.11ac Wireless LAN</br > Bluetooth 4.1", SortOrder = 0, Position = 7 },
                        new() { ProductId = _RazerBladeGTX1060, SpecificationId = _interface, Value = "2 x USB 3.0<br /> 1 x Thunderbolt 3<br /> 1 x HDMI (4K @ 60Hz)", SortOrder = 0, Position = 8 },
                        new() { ProductId = _RazerBladeGTX1060, SpecificationId = battery, Value = "Built-in 70 Wh rechargeable lithium-ion polymer battery", SortOrder = 0, Position = 9 },
                        new() { ProductId = _RazerBladeGTX1060, SpecificationId = dimensions, Value = "13.60\" x 9.30\" x 0.70\" (WxDxH)", SortOrder = 0, Position = 10 },
                        new() { ProductId = _RazerBladeGTX1060, SpecificationId = weight, Value = "4.10 lbs.", SortOrder = 0, Position = 11 }
                    ]
            };
            _context.Products.Add(product7);
            _context.SaveChanges();

            var product8 = new Product // AMD RYZEN 7 1800X
            {
                Id = _AmdRyzen71800X,
                Name = "AMD RYZEN 7 1800X 8-Core 3.6 GHz (4.0 GHz Turbo) Socket AM4 95W Desktop Processor",
                Description = "",
                RetailPrice = 499.99m,
                StockQuantity = 1000,
                NotifyForQuantityBelow = 1,
                MinimumCartQuantity = 1,
                MaximumCartQuantity = 1000,
                SeoUrl = "AMD-RYZEN-7-1800X-8Core-36-GHz-40-GHz-Turbo-Socket-AM4-95W-Desktop-Processor",
                Published = true,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Categories =
                    [
                        new ProductCategoryMapping { ProductId = _AmdRyzen71800X, CategoryId = processors }
                    ],
                Manufacturers =
                    [
                        new ProductManufacturerMapping { ProductId = _AmdRyzen71800X, ManufacturerId = amd }
                    ],
                Images =
                    [
                        new ProductImageMapping { ProductId = _AmdRyzen71800X, ImageId = i_Ryzen71800x, SortOrder = 0, Position = 0 }
                    ],
                Specifications =
                    [
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = brand, Value = "AMD", SortOrder = 0, Position = 0 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = processorsType, Value = "Desktop", SortOrder = 0, Position = 1 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = series, Value = "Ryzen 7", SortOrder = 0, Position = 2 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = cpuSocketType, Value = "Socket AM4", SortOrder = 0, Position = 3 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = coreName, Value = "Summit Ridge", SortOrder = 0, Position = 4 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = numberOfCores, Value = "8-Core", SortOrder = 0, Position = 5 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = numberOfThreads, Value = "16", SortOrder = 0, Position = 6 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = operatingFrequency, Value = "3.6 GHz", SortOrder = 0, Position = 7 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = maxTurboFrequency, Value = "4.0 GHz", SortOrder = 0, Position = 8 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = l2Cache, Value = "4MB", SortOrder = 0, Position = 9 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = l3Cache, Value = "16MB", SortOrder = 0, Position = 10 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = manufacturingTech, Value = "14nm", SortOrder = 0, Position = 11 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = virtualizationTechnologySupport, Value = "Yes", SortOrder = 0, Position = 12 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = thermalDesignPower, Value = "95W", SortOrder = 0, Position = 13 },
                        new() { ProductId = _AmdRyzen71800X, SpecificationId = coolingDevice, Value = "Cooling device not included - Processor Only", SortOrder = 0, Position = 14 }
                    ]
            };
            _context.Products.Add(product8);
            _context.SaveChanges();

            var product9 = new Product // Logitech G502
            {
                Id = _LogitechG502,
                Name = "Logitech G502 Proteus Spectrum RGB Tunable Gaming Mouse",
                Description = "<p><strong>Logitech G502 Proteus Spectrum RGB Tunable Gaming Mouse</strong><br /><strong>Your favorite high-performance gaming mouse delivers more than ever.</strong><br /><img alt=\"\" src=\"https://a.sellpoint.net/a/rYBWPaxG_M.jpg\" style=\"height:215px; width:250px\" /><br />G502 features our most advanced optical sensor for maximum tracking accuracy. Customize RGB lighting or sync it with other Logitech G products, set up custom profiles for your games, adjust sensitivity from 200 up to 12,000 DPI* and position five 3.6g weights for just the right balance and feel. No matter your gaming style, it's easy to tweak Proteus Spectrum to match you.</p><hr /><p><strong>Tunable weight and balance<br /><img alt=\"\" src=\"https://a.sellpoint.net/a/4oPJ8dPG_B.jpg\" style=\"height:250px; width:250px\" /></strong><br />Personal tweaks make all the difference. Position a few or all five of the 3.6g weights for a mouse that feels just right for you.</p><hr /><p><strong>RGB customizable lighting<br />Match your style and environment.<br /><img alt=\"\" src=\"https://a.sellpoint.net/a/aYdMmJ8G_B.jpg\" style=\"height:250px; width:250px\" /></strong></p><ul><li><p>Adjust up to 16.8 million colors and brightness.*</p></li><li><p>Bring your mouse to life with breathing light patterns.</p></li><li><p>Set your lighting to sleep when you aren't using your system.</p></li></ul><p>*Some profile settings require Logitech Gaming Software available at logitech.com/downloads.</p><hr /><p><strong>Accurate, responsive optical sensor<br />Get maximum tracking accuracy from our most responsive optical sensor (PMW3366).&nbsp;<br /><img alt=\"\" src=\"https://a.sellpoint.net/a/LoR14x0k_B.jpg\" style=\"height:250px; width:250px\" /></strong></p><ul><li><p>Exclusive Logitech-G Delta Zero optical sensor technology minimizes mouse acceleration and increases reliable targeting.</p></li></ul><hr /><p><strong>Easy-to-program Logitech Gaming Software<br /><img alt=\"\" src=\"https://a.sellpoint.net/a/nkxejWvo_B.jpg\" style=\"height:250px; width:250px\" /></strong></p><ul><li><p>Sync colors and light patterns with other Logitech-G RGB gaming products.</p></li><li><p>Tune the sensor to match the surface for maximum speed and lower lift-off.</p></li><li><p>Program buttons with custom macros.</p></li><li><p>Manage lighting, DPI sensitivity, and button profiles.</p></li></ul><p>\u00A0</p><hr /><p><strong>Comfortable design for expended gaming<br />Experience an overall great feel and stellar performance from day one.<br /><img alt=\"\" src=\"https://a.sellpoint.net/a/5GjEBD3Y_B.jpg\" style=\"height:250px; width:250px\" /></strong></p><ul><li><p>Sculpted, hand-supporting shape</p></li><li><p>Textured rubber grips</p></li><li><p>Convenient button layout for fast, accurate actions</p></li></ul><hr /><p><strong>Customizable control<br /><img alt=\"\" src=\"https://a.sellpoint.net/a/JYXwWv0o_B.jpg\" style=\"height:250px; width:250px\" /></strong></p><ul><li><p>Easily customize 11 programmable buttons for your favorite games.</p></li><li><p>Adjust hyper-fast scrolling to just your speed.</p></li><li><p>Switch DPI modes on the fly -- choose from five settings from 200 to 12,000 DPI*.</p></li></ul>",
                RetailPrice = 69.79m,
                SpecialPrice = 39.79m,
                SpecialPriceStartDate = DateTime.Now,
                SpecialPriceEndDate = DateTime.Now.AddDays(30),
                StockQuantity = 1000,
                NotifyForQuantityBelow = 1,
                MinimumCartQuantity = 1,
                MaximumCartQuantity = 1000,
                SeoUrl = "Logitech-G502-Proteus-Spectrum-RGB-Tunable-Gaming-Mouse",
                Published = true,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Categories =
                    [
                        new ProductCategoryMapping { ProductId = _LogitechG502, CategoryId = mouse }
                    ],
                Manufacturers =
                    [
                        new ProductManufacturerMapping { ProductId = _LogitechG502, ManufacturerId = logitech }
                    ],
                Images =
                    [
                        new ProductImageMapping { ProductId = _LogitechG502, ImageId = i_LogitechG502Main, SortOrder = 0, Position = 0 },
                        new ProductImageMapping { ProductId = _LogitechG502, ImageId = i_LogitechG502Side, SortOrder = 0, Position = 1 },
                        new ProductImageMapping { ProductId = _LogitechG502, ImageId = i_LogitechG502Bottom, SortOrder = 0, Position = 2 }
                    ],
                Specifications =
                    [
                        new() { ProductId = _LogitechG502, SpecificationId = brand, Value = "Logitech", SortOrder = 0, Position = 0 },
                        new() { ProductId = _LogitechG502, SpecificationId = name, Value = "G502", SortOrder = 0, Position = 1 },
                        new() { ProductId = _LogitechG502, SpecificationId = model, Value = "910-004615", SortOrder = 0, Position = 2 },
                        new() { ProductId = _LogitechG502, SpecificationId = type, Value = "Wired", SortOrder = 0, Position = 3 },
                        new() { ProductId = _LogitechG502, SpecificationId = _interface, Value = "USB", SortOrder = 0, Position = 4 },
                        new() { ProductId = _LogitechG502, SpecificationId = mouseGripStyle, Value = "Fingertip", SortOrder = 0, Position = 5 },
                        new() { ProductId = _LogitechG502, SpecificationId = trackingMethod, Value = "Optical", SortOrder = 0, Position = 6 },
                        new() { ProductId = _LogitechG502, SpecificationId = maximumDpi, Value = "12000 dpi", SortOrder = 0, Position = 7 },
                        new() { ProductId = _LogitechG502, SpecificationId = handOrientation, Value = "Right Hand", SortOrder = 0, Position = 8 },
                        new() { ProductId = _LogitechG502, SpecificationId = buttons, Value = "11", SortOrder = 0, Position = 9 },
                        new() { ProductId = _LogitechG502, SpecificationId = mouseAdjustableWeight, Value = "5 x 3.6 g weights", SortOrder = 0, Position = 10 },
                        new() { ProductId = _LogitechG502, SpecificationId = scrollingCapability, Value = "Tilt Wheel", SortOrder = 0, Position = 11 },
                        new() { ProductId = _LogitechG502, SpecificationId = color, Value = "Black", SortOrder = 0, Position = 12 },
                        new() { ProductId = _LogitechG502, SpecificationId = operatingSystemSupported, Value = "Windows 10, Windows 8.1, Windows 8, Windows 7", SortOrder = 0, Position = 13 },
                        new() { ProductId = _LogitechG502, SpecificationId = systemRequirement, Value = "USB port<br /> Internet connection for optional software download", SortOrder = 0, Position = 14 },
                        new() { ProductId = _LogitechG502, SpecificationId = features, Value = "Accurate responsive optical sensor<br /> Balance And Weight At Your Control<br /> Programmable RGB Lighting<br /> Personally-tuned performance<br /> 11 Programmable buttons<br /> DPI Shift In-game<br /> Dual-mode, Gaming-grade Scroll Wheel<br /> Our most accurate sensor on the market<br /> 32-bit microcontroller<br /> 3 on-board profiles<br /> 1 millisecond report rate<br /> Primary buttons rated to 20 million clicks<br /> Mechanical microswitches<br /> Improved keyplate design for better click feeling and performance<br /> Braided cable with hook and loop cable tie<br /> Sleep mode disabled<br /> 3 DPI indicator LEDs<br /> Rubber grips<br /> Magnetic weight-cavity door<br />", SortOrder = 0, Position = 15 }
                    ]

            };
            _context.Products.Add(product9);
            _context.SaveChanges();




        }

        return Task.CompletedTask;
    }
}