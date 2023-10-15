﻿using ETicaretAPI.Application.Features.Commands.ProductImageFiles.ChangeShowcaseImage;
using ETicaretAPI.Application.Features.Commands.ProductImageFiles.RemoveProductImage;
using ETicaretAPI.Application.Features.Commands.ProductImageFiles.UploadProductImage;
using ETicaretAPI.Application.Features.Commands.Products.CreateProduct;
using ETicaretAPI.Application.Features.Commands.Products.RemoveProduct;
using ETicaretAPI.Application.Features.Commands.Products.UpdateProduct;
using ETicaretAPI.Application.Features.Queries.ProductImageFiles.GetProductImages;
using ETicaretAPI.Application.Features.Queries.Products.GetAllProduct;
using ETicaretAPI.Application.Features.Queries.Products.GetByIdProduct;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
        {
            GetAllProductQueryResponse getAllProductQueryResponse = await _mediator.Send(getAllProductQueryRequest);
            return Ok(getAllProductQueryResponse);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            GetByIdProductQueryResponse response = await _mediator.Send(getByIdProductQueryRequest);
            return Ok(response);
        }
        [HttpPost]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> Post([FromBody] CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> Put([FromBody] UpdateProductCommandRequest updateProductCommandRequest)
        {
            UpdateProductCommandResponse updateProductCommandResponse = await _mediator.Send(updateProductCommandRequest);
            return StatusCode((int)HttpStatusCode.NoContent);
        }
        [HttpDelete("{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> Delete([FromRoute] RemoveProductCommandRequest removeProductCommandRequest)
        {
            RemoveProductCommandResponse removeProductCommandResponse = await _mediator.Send(removeProductCommandRequest);
            return NoContent();
        }

        [HttpPost("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> Upload([FromQuery] UploadProductImageCommandRequest uploadProductImageCommandRequest)
        {
            uploadProductImageCommandRequest.Files = Request.Form.Files;
            UploadProductImageCommandResponse uploadProductImageCommandResponse = await _mediator.Send(uploadProductImageCommandRequest);
            return Ok();
        }

        [HttpGet("[action]/{id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> GetProductImages([FromRoute] GetProductImagesQueryRequest getProductImagesQueryRequest)
        {
            List<GetProductImagesQueryResponse> getProductImagesQueryResponse = await _mediator.Send(getProductImagesQueryRequest);
            return Ok(getProductImagesQueryResponse);
        }

        [HttpDelete("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> DeleteProductImage([FromRoute] RemoveProductImageCommandRequest removeProductImageCommandRequest, [FromQuery] string ImageId)
        {
            removeProductImageCommandRequest.ImageId = ImageId;
            RemoveProductImageCommandResponse removeProductImageCommandResponse = await _mediator.Send(removeProductImageCommandRequest);
            return Ok();
        }

        [HttpGet("[action]")]
        [Authorize(AuthenticationSchemes ="Admin")]
        public async Task <IActionResult> ChangeShowcaseImage([FromQuery]ChangeShowcaseImageCommandRequest changeShowcaseImageCommandRequest)
        {
            ChangeShowcaseImageCommandResponse response=await _mediator.Send(changeShowcaseImageCommandRequest);
            return Ok(response);
        }
    }
}
