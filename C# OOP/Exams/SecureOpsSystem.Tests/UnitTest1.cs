using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SecureOpsSystem.Tests
{
    [TestFixture]
    public class SecureHubTests
    {
        [Test]
        public void SecureHubCreatedSuccessfully()
        {
            SecureHub secureHub = new SecureHub(50);

            Assert.NotNull(secureHub);
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void ThrowsWhenCapacityIsZeroOrNegative(int value)
        {
            Assert.Throws<ArgumentException>(() => { SecureHub negativeCapacityHub = new SecureHub(value); });
        }

        [Test]
        public void CapacityIsGreaterThanZero()
        {
            Assert.DoesNotThrow(() => { SecureHub positiveCapacityHub = new SecureHub(50); });
        }
        

        [Test]
        public void ToolsAreInitializedSuccessfully()
        {
            SecureHub secureHub = new SecureHub(50);

            Assert.AreEqual(0, secureHub.Tools.Count);
        }
        [Test]
        public void ToolIsAddedSuccessfully()
        {
            SecureHub secureHub = new SecureHub(50);
            SecurityTool securityTool = new SecurityTool("tool", "category1", 250);

            secureHub.AddTool(securityTool);

            Assert.AreEqual(1, secureHub.Tools.Count);
        }
        [Test]
        public void ToolIsNotAddedBecauseItIsAlreadyInTheHub()
        {
            SecureHub secureHub = new SecureHub(50);
            SecurityTool securityTool = new SecurityTool("tool", "category1", 250);
            SecurityTool sameSecurityTool = new SecurityTool("tool", "category2", 300);

            secureHub.AddTool(securityTool);

            Assert.AreEqual($"Security Tool {securityTool.Name} already exists in the hub.", secureHub.AddTool(sameSecurityTool));
        }

        [TestCase(2)]
        public void CannotAddAToolIfToolCountIsGreaterOrEqualToCapacity(int capacity)
        {
            SecureHub secureHub = new SecureHub(capacity);
            SecurityTool securityTool = new SecurityTool("tool", "category1", 250);
            SecurityTool newSecurityTool = new SecurityTool("new tool", "category2", 300);
            SecurityTool newerSecurityTool = new SecurityTool("newer tool", "category3", 400);
            SecurityTool anotherSecurityTool = new SecurityTool("another tool", "category4", 500);

            secureHub.AddTool(securityTool);
            secureHub.AddTool(newerSecurityTool);
            Assert.AreEqual("Secure Hub is at full capacity.", secureHub.AddTool(newSecurityTool));
            Assert.AreEqual("Secure Hub is at full capacity.", secureHub.AddTool(anotherSecurityTool));
        }

        [TestCase("tool")]
        public void SecurityToolIsAddedSuccessfully(string name)
        {
            SecureHub secureHub = new SecureHub(10);
            SecurityTool securityTool = new SecurityTool("tool", "category1", 100);

            Assert.AreEqual($"Security Tool {name} added successfully.", secureHub.AddTool(securityTool));
        }

        [Test]
        public void ToolToRemoveIsNotFound()
        {
            SecureHub secureHub = new SecureHub(10);
            SecurityTool securityTool = new SecurityTool("tool", "category1", 100);
            SecurityTool newSecurityTool = new SecurityTool("tool2", "category2", 200);

            secureHub.AddTool(securityTool);

            Assert.False(secureHub.RemoveTool(newSecurityTool));
        }

        [Test]
        public void ToolIsRemovedSuccessfully()
        {
            SecureHub secureHub = new SecureHub(10);
            SecurityTool securityTool = new SecurityTool("tool", "category1", 100);

            secureHub.AddTool(securityTool);

            Assert.True(secureHub.RemoveTool(securityTool));
            Assert.AreEqual(0, secureHub.Tools.Count);
        }

        [Test]
        public void DeployToolReturnsNull()
        {
            SecureHub secureHub = new SecureHub(10);
            SecurityTool securityTool = new SecurityTool("tool", "category1", 100);
            SecurityTool securityTool2 = new SecurityTool("tool2", "category2", 200);
            SecurityTool securityTool3 = new SecurityTool("tool3", "category3", 300);

            secureHub.AddTool(securityTool);
            secureHub.AddTool(securityTool2);
            secureHub.AddTool(securityTool3);

            Assert.Null(secureHub.DeployTool("tool1"));
        }

        [Test]
        public void DeployToolDoesNotReturnNull()
        {
            SecureHub secureHub = new SecureHub(10);
            SecurityTool securityTool = new SecurityTool("tool", "category1", 100);
            SecurityTool securityTool2 = new SecurityTool("tool2", "category2", 200);
            SecurityTool securityTool3 = new SecurityTool("tool3", "category3", 300);

            secureHub.AddTool(securityTool);
            secureHub.AddTool(securityTool2);
            secureHub.AddTool(securityTool3);

            Assert.NotNull(secureHub.DeployTool("tool"));
            Assert.AreEqual(2, secureHub.Tools.Count);
        }

        [Test]
        public void SystemReportIsWorkingCorrectly()
        {
            SecureHub secureHub = new SecureHub(10);
            SecurityTool securityTool1 = new SecurityTool("tool1", "category1", 100);
            SecurityTool securityTool2 = new SecurityTool("tool2", "category2", 200);
            SecurityTool securityTool3 = new SecurityTool("tool3", "category3", 300);

            secureHub.AddTool(securityTool1);
            secureHub.AddTool(securityTool2);
            secureHub.AddTool(securityTool3);

            StringBuilder sb2 = new StringBuilder();
            sb2.AppendLine("Secure Hub Report:");
            sb2.AppendLine($"Available Tools: {secureHub.Tools.Count}");
            sb2.AppendLine("Name: tool3, Category: category3, Effectiveness: 300.00");
            sb2.AppendLine("Name: tool2, Category: category2, Effectiveness: 200.00");
            sb2.AppendLine("Name: tool1, Category: category1, Effectiveness: 100.00");

            Assert.AreEqual(secureHub.SystemReport().TrimEnd(), sb2.ToString().TrimEnd());
        }
    }
}