﻿// <auto-generated />

using System;
using Brickweave.EventStore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Brickweave.Samples.WebApp.Data.Migrations.EventStore
{
    [DbContext(typeof(EventStoreContext))]
    partial class EventStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("EventStore")
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Brickweave.EventStore.SqlServer.Entities.EventData", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CommitSequence");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Json");

                    b.Property<Guid>("StreamId");

                    b.HasKey("EventId");

                    b.ToTable("Event");
                });
#pragma warning restore 612, 618
        }
    }
}
