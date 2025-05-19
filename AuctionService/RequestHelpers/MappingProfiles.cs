using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelpers;

// profile belong to auto mapper

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
        CreateMap<Item, AuctionDto>();
        CreateMap<CreateAuctionDto, Auction>()
            .ForMember(destination =>
                    destination.Item,
                opt => opt.MapFrom(source => source)
            );
        CreateMap<CreateAuctionDto, Item>();
    }
}